using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Generic interface, used to add attack logic to an agent
public interface IAttackable
{
    void DealDamage();

    void DealDamage(Collider collision);

}
