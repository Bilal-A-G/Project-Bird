using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootable
{
    bool Shoot(WeaponObject weaponStats, bool dryFiring);
}
