using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidAttack : MonoBehaviour, IAttackable
{
    public float attackDamage;
    public float hitForgiveness;
    public float range;

    float timeSinceLastAttack;

    public void DealDamage()
    {
        RaycastHit collision;

        if(Physics.Raycast(transform.position, transform.forward, out collision))
        {
            if (collision.collider.gameObject.tag == "Player" && collision.collider.gameObject.GetComponent<IKillable>() != null && (collision.collider.gameObject.transform.position - transform.position).magnitude <= range)
            {
                if (timeSinceLastAttack + hitForgiveness < Time.time)
                {
                    timeSinceLastAttack = Time.time;
                    collision.collider.gameObject.GetComponent<IKillable>().TakeDamage(attackDamage);
                }
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
