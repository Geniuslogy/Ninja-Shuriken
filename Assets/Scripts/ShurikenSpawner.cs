using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenSpawner : MonoBehaviour
{
    public GameObject shuriken;

    public float SpawnRate;

    public float MinXPos;
    public float MaxXPos;


    // Start is called before the first frame update
    void Start()
    {
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        float position_x = Random.Range(MinXPos, MaxXPos);

        Vector2 SpawnPosition = new Vector2(position_x, transform.position.y);

        Instantiate(shuriken, SpawnPosition, Quaternion.identity);
    }

    void StartSpawning()
    {
        InvokeRepeating("Spawn", 1f, SpawnRate);
    }

    public void StopSpawning()
    {
        CancelInvoke("Spawn");
    }

}
