using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M1911Reloading : MonoBehaviour, IReloadable
{
    float currentAmmo;

    public void DecreaseCurrentAmmo()
    {
        currentAmmo--;
    }

    public float GetCurrentAmmo() => currentAmmo;

    public void Reload(WeaponObject weaponStats)
    {
        currentAmmo = weaponStats.maxAmmo;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
