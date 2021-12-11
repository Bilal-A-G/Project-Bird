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
                    Debug.Log("Hit something");
                }
            }

            Debug.Log("Bang");
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
