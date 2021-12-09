using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Generic interface, used to add attack logic to an agent
public interface IAttackable
{
    //Generic method that will deal damage to an agent based on a collision
    void DealDamage(Collision collision);

}
