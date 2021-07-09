using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Transform spawnTransform;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies", 2, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemies() {
        spawnTransform.position = new Vector3 (Random.Range (0f, 10f), 18f, 0f);
        GameObject enemy1 = Instantiate(enemy, spawnTransform) as GameObject;
        // enemy1.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}