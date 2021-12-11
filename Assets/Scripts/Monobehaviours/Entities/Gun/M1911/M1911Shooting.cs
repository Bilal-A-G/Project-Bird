using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M1911Shooting : MonoBehaviour, IShootable
{
    bool isShooting;

    public void Shoot(WeaponObject weaponStats)
    {
        isShooting = !isShooting;

        RaycastHit raycastHit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out raycastHit) && isShooting)
        {
            if((raycastHit.point - transform.position).magnitude <= weaponStats.maxRange)
            {
                Debug.Log(weaponStats.maxRange / (raycastHit.point - transform.position).magnitude * weaponStats.maxDamage);
            }
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
