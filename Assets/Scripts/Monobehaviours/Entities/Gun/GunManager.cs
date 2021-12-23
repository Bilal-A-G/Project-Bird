using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GunManager : MonoBehaviour
{
    public List<WeaponObject> weapons;
    [HideInInspector]
    public WeaponObject currentWeapon;

    public TextMeshProUGUI ammoCount;

    InputActions inputActions;

    IReloadable reloadLogic;
    IShootable shootingLogic;

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void Awake()
    {
        currentWeapon = weapons[0];

        inputActions = new InputActions();

        inputActions.PC.Reload.performed += ctx => reloadLogic.Reload(currentWeapon, true);
        inputActions.PC.Shoot.performed += ctx =>
        {
            if (reloadLogic.GetCurrentAmmo() > 0)
            {
                if (shootingLogic.Shoot(currentWeapon, false))
                {
                    reloadLogic.DecreaseCurrentAmmo();
                }
            }
            else
            {
                shootingLogic.Shoot(currentWeapon, true);
            }
        };
    }

    void Start()
    {
        UpdateWeapon();
    }

    void Update()
    {
        ammoCount.text = ("Ammo: " + reloadLogic.GetCurrentAmmo().ToString() + "/ " + currentWeapon.maxAmmo.ToString());
    }

    void UpdateWeapon()
    {
        reloadLogic = transform.GetChild(0).GetComponent<IReloadable>();
        shootingLogic = transform.GetChild(0).GetComponent<IShootable>();

        reloadLogic.Reload(currentWeapon, false);
    }
}
