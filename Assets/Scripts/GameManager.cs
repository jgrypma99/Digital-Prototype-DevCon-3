using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//handles various functions related to gameplay
public class GameManager : MonoBehaviour
{
    public int totalScore;
    public GameObject[] slimes;
    public Transform SpawnPoint;
    public float spawnTime = 5f;

    // Update is called once per frame
    void Update()
    {
        //spawn slimes at an interval of one every five seconds
        spawnTime -= Time.deltaTime;

        if (spawnTime <= 0 )
        {
            Instantiate(slimes[Random.Range(0, slimes.Length)], SpawnPoint.position, Quaternion.identity);
            spawnTime = 5;
        }
    }
}
