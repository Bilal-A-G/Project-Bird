using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M1911Shooting : MonoBehaviour, IShootable
{
    bool isShooting;
    Animator animator;
    ParticleSystem muzzleFlash;
    AudioSource audioSource;

    public GameObject impactObject;

    float timeSinceLastShot;
     
    public bool Shoot(WeaponObject weaponStats, bool dryFiring)
    {
        isShooting = !isShooting;

        RaycastHit raycastHit;

        if (isShooting && Time.time > timeSinceLastShot + 1/weaponStats.fireRate)
        {
            if (!dryFiring)
            {
                audioSource.clip = weaponStats.fireSound;
            }
            else
            {
                audioSource.clip = weaponStats.dryFireSound;
            }
            audioSource.Play();

            if (!dryFiring)
            {
                animator.SetTrigger("Fire");
                muzzleFlash.Play();

                if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out raycastHit))
                {
                    GameObject impactBox = Instantiate(impactObject);
                    AudioSource impactSound = impactBox.GetComponent<AudioSource>();
                    ParticleSystem impactParticles = impactBox.GetComponent<ParticleSystem>();

                    ParticleSystem.MainModule settings = impactParticles.main;

                    impactBox.transform.position = raycastHit.point;

                    if ((raycastHit.point - transform.position).magnitude <= weaponStats.maxRange)
                    {
                        if (raycastHit.collider.gameObject.GetComponent<IKillable>() != null)
                        {
                            impactSound.clip = weaponStats.hitSound;
                            settings.startColor = Color.red;

                            raycastHit.collider.gameObject.GetComponent<IKillable>().TakeDamage(weaponStats.maxDamage);
                        }
                        else
                        {
                            impactSound.clip = weaponStats.hitEnvironmentSound;
                            settings.startColor = raycastHit.collider.gameObject.GetComponent<Renderer>().material.color;
                        }

                        impactSound.Play();
                        Destroy(impactBox, 3f);
                    }
                }

                timeSinceLastShot = Time.time;

                return true;
            }
        }

        return false;
    }

    void Start()
    {
        animator = GetComponent<Animator>();
        muzzleFlash = GetComponentInChildren<ParticleSystem>();
        audioSource = GetComponentInChildren<AudioSource>();
    }

    void Update()
    {
        
    }
}
