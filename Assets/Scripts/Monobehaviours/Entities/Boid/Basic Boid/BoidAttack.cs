using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidAttack : MonoBehaviour, IAttackable
{
    public float attackDamage;

    public void DealDamage(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && collision.gameObject.GetComponent<IKillable>() != null)
        {
            collision.gameObject.GetComponent<IKillable>().TakeDamage(attackDamage);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
