using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlatformAttack : MonoBehaviour, IAttackable
{
    public void DealDamage() => new System.NotImplementedException();

    public void DealDamage(Collider collision)
    {
        if(collision.gameObject.GetComponent<IKillable>() != null)
        {
            collision.gameObject.GetComponent<IKillable>().TakeDamage(1000);
        }
    }
}
