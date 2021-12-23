using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M1911Reloading : MonoBehaviour, IReloadable
{
    float currentAmmo;
    AudioSource audioSource;

    public void DecreaseCurrentAmmo()
    {
        currentAmmo--;
    }

    public float GetCurrentAmmo() => currentAmmo;

    public void Reload(WeaponObject weaponStats, bool playSound)
    {
        currentAmmo = weaponStats.maxAmmo;
        if (playSound)
        {
            audioSource.clip = weaponStats.reloadSound;
            audioSource.Play();
        }
    }

    void Start()
    {
        audioSource = GetComponentInChildren<AudioSource>();
    }

    void Update()
    {
        
    }
}
