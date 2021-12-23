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
                Wave newWave = new Wave(Random.Range(1, 20) + currentWaveNumber * difficultyScale);
                waves.Add(newWave);
            }
            for (int i = 0; i < waves[currentWaveNumber].numberOfEnemies; i++)
            {
                SpawnEnemy(i);
            }
        }

        waveCounter.text = "Wave " + currentWaveNumber + 1;
    }

    void SpawnEnemy(int offset)
    {
        GameObject enemy = Instantiate(enemyModel, transform);
        enemy.transform.position = spawnPosition + new Vector3(0, offset * enemy.transform.localScale.y, 0);
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
