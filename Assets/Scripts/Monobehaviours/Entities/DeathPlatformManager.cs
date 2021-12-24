using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlatformManager : MonoBehaviour
{
    IAttackable attackLogic;

    void Start()
    {
        attackLogic = GetComponent<IAttackable>();
    }

    private void OnTriggerEnter(Collider other)
    {
        attackLogic.DealDamage(other);
    }
}
