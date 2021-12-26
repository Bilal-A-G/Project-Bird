using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager instance { get; private set; }
    public GameObject enemyModel;
    public Vector3 spawnPosition;
    public TextMeshProUGUI waveCounter;

    public float randomizeLocationDevianceX;
    public float randomizeLocationDevianceZ;

    public List<Wave> waves;
    public int difficultyScale;

    int currentWaveNumber;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        currentWaveNumber = -1;
    }

    private void Update()
    {
        UpdateWave();
    }

    public void UpdateWave()
    {
        if(transform.childCount == 0)
        {
            currentWaveNumber++;

            if (waves.Count - 1 < currentWaveNumber)
            {
                Wave newWave = new Wave(Random.Range(1, 3) + currentWaveNumber * difficultyScale);
                waves.Add(newWave);
            }
            for (int i = 0; i < waves[currentWaveNumber].numberOfEnemies; i++)
            {
                SpawnEnemy();
            }
        }

        waveCounter.text = "Wave " + (currentWaveNumber + 1);
    }

    void SpawnEnemy()
    {
        GameObject enemy = Instantiate(enemyModel, transform);
        Vector3 randomizedLocation = new Vector3(Random.Range(-randomizeLocationDevianceX, randomizeLocationDevianceX), 0, Random.Range(-randomizeLocationDevianceZ, randomizeLocationDevianceZ));
        Vector3 finalObjectLocation = spawnPosition + randomizedLocation;

        enemy.transform.position = finalObjectLocation;
        enemy.SetActive(true);
    }

    [System.Serializable]
    public struct Wave
    {
        public int numberOfEnemies;

        public Wave(int enemies)
        {
            numberOfEnemies = enemies;
        }
    }
}
