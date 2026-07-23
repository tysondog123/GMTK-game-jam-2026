using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject enemy;
    [SerializeField]
    SpawnPoints[] SpawnPoints;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(FindSpawnPoint());
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    Vector3 FindSpawnPoint()
    {
        int ran = Random.Range(0, SpawnPoints.Length);
        return SpawnPoints[ran].FindPointAlongspan();
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1);
        Instantiate(enemy, FindSpawnPoint(), quaternion.identity);
        StartCoroutine(Spawn());
    }
}
