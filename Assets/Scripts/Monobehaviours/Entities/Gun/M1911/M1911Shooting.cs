using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M1911Shooting : MonoBehaviour, IShootable
{
    bool isShooting;

    public bool Shoot(WeaponObject weaponStats)
    {
        isShooting = !isShooting;

        RaycastHit raycastHit;

        if (isShooting)
        {
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out raycastHit))
            {
                if ((raycastHit.point - transform.position).magnitude <= weaponStats.maxRange)
                {
                    if(raycastHit.collider.gameObject.GetComponent<IKillable>() != null)
                    {
                        raycastHit.collider.gameObject.GetComponent<IKillable>().TakeDamage(weaponStats.maxDamage);
                    }
                }
            }
            return true;
        }

        return false;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
