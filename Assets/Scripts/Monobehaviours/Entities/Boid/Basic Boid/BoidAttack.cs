using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidAttack : MonoBehaviour, IAttackable
{
    public float attackDamage;
    public float hitForgiveness;

    float timeSinceLastAttack;

    public void DealDamage(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && collision.gameObject.GetComponent<IKillable>() != null)
        {
            Debug.Log("Trying to hit");

            if(timeSinceLastAttack + hitForgiveness < Time.time)
            {
                timeSinceLastAttack = Time.time;
                collision.gameObject.GetComponent<IKillable>().TakeDamage(attackDamage);
            }
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
