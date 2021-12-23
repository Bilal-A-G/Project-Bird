using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapons")]
public class WeaponObject : ScriptableObject
{
    public float maxDamage;
    public float maxRange;
    public float maxAmmo;
    public float fireRate;

    public AudioClip fireSound;
    public AudioClip dryFireSound;
    public AudioClip reloadSound;
    public AudioClip hitSound;
    public AudioClip hitEnvironmentSound;
}
