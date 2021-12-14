using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour, IKillable
{
    public float maxHealth;
    float currentHealth;

    public void Die()
    {
        Debug.Log("Dead");
        currentHealth = maxHealth;
    }

    public float GetCurrentHealth() => currentHealth;

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
    }

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        
    }
}
