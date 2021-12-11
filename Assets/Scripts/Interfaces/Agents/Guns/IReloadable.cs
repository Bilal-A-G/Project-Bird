using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IReloadable
{
    void Reload(WeaponObject weaponStats);

    float GetCurrentAmmo();

    void DecreaseCurrentAmmo();
}
