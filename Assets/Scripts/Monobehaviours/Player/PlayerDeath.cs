using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour, IKillable
{
    public float maxHealth;
    float currentHealth;

    public Vector3 respawnPosition;

    public void Die()
    {
        SceneManager.LoadScene("GameOver");
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
