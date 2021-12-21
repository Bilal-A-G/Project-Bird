using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidDeath : MonoBehaviour, IKillable
{
    public float maxHealth;
    float currentHealth;

    public void Die()
    {
        Destroy(gameObject);
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
