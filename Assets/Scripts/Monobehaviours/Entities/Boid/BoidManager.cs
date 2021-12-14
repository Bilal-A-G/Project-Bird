using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidManager : MonoBehaviour
{
    IMovable movementLogic;
    IKillable deathLogic;
    IAttackable attackLogic;

    private void Awake()
    {
        movementLogic = GetComponent<IMovable>();
        deathLogic = GetComponent<IKillable>();
        attackLogic = GetComponent<IAttackable>();
    }

    private void Update()
    {
        if (deathLogic.GetCurrentHealth() <= 0)
        {
            deathLogic.Die();
        }

        movementLogic.Move(IMovable.MoveDirections.Any);
    }

    private void OnCollisionEnter(Collision collision)
    {
        attackLogic.DealDamage(collision);
    }
}
