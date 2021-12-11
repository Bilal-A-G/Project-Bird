using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    public List<WeaponObject> weapons;
    [HideInInspector]
    public WeaponObject currentWeapon;

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

        inputActions.PC.Reload.performed += ctx => reloadLogic.Reload(currentWeapon);
        inputActions.PC.Shoot.performed += ctx =>
        {
            if (reloadLogic.GetCurrentAmmo() > 0)
            {
                if (shootingLogic.Shoot(currentWeapon))
                {
                    reloadLogic.DecreaseCurrentAmmo();
                }
            }
            else
            {
                reloadLogic.Reload(currentWeapon);
            }
        };
    }

    void Start()
    {
        UpdateWeapon();
    }

    void Update()
    {
        
    }

    void UpdateWeapon()
    {
        reloadLogic = transform.GetChild(0).GetComponent<IReloadable>();
        shootingLogic = transform.GetChild(0).GetComponent<IShootable>();

        reloadLogic.Reload(currentWeapon);
    }
}
