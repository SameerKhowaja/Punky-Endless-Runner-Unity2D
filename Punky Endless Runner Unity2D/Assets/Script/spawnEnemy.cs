using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float startTime;
    public float waveTime;

    Vector3 RandomPos_Plus;

    void Update()
    {
        if(Time.time > startTime)
        {
            RandomPos_Plus = new Vector3(0f, Random.Range(0f, 0.5f), 0f);
            Instantiate(enemyPrefab, transform.position + RandomPos_Plus, Quaternion.identity);
            startTime = Time.time + waveTime;
        }
    }
}
