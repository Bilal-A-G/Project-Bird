using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour, IKillable
{
    float currentHealth;
    float trauma;

    public float maxHealth;
    public Camera mainCamera;
    public float traumaDecreaseRate;
    public AudioClip hitSound;
    public AudioSource soundSource;

    public Vector3 screenshakeYawPitchRoll;

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
        trauma += 1 / damage;

        soundSource.clip = hitSound;
        soundSource.Play();
    }

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        Vector3 screenshake = screenshakeYawPitchRoll * trauma * Random.Range(-1f, 1f);
        if(trauma > 0)
        {
            trauma -= traumaDecreaseRate * Time.deltaTime;
        }
        else
        {
            trauma = 0;
        }

        mainCamera.transform.eulerAngles += screenshake;
    }
}
