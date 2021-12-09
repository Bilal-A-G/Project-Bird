using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Generic interface, used to add damage logic to an agent
public interface IKillable
{
    //Generic method that will kill an agent
    void Die();

    //Generic method that will return the current health of an agent
    float GetCurrentHealth();
}
