
using UnityEngine;
using System;
using System.Collections;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public UnityEngine.GameObject obstaclePrefab;
    public UnityEngine.GameObject obstaclePrefabtwo;
    public UnityEngine.GameObject obstaclePrefabthree;

    void SpawnObstacle()
    {
        GameObject[] obstacles = new GameObject[4];
        obstacles.SetValue(obstaclePrefab, 1);
        obstacles.SetValue(obstaclePrefabtwo, 2);
        obstacles.SetValue(obstaclePrefabthree, 3);
        System.Random rand = new System.Random();
        int rndnmb = rand.Next(1, 4);
        int obstacleSpawnIndex = UnityEngine.Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        Instantiate(obstacles[rndnmb], spawnPoint.position, Quaternion.identity, transform);
    }

    
}

