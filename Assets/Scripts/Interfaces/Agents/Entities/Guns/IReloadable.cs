using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IReloadable
{
    void Reload(WeaponObject weaponStats, bool playSound);

    float GetCurrentAmmo();

    void DecreaseCurrentAmmo();
}
