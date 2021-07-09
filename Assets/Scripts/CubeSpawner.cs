using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] Transform spawnTransform;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCubes", 2, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCubes() {
        spawnTransform.position = new Vector3 (Random.Range (0f, 10f), 18f, 0f);
        GameObject cube1 =Instantiate(cube, spawnTransform) as GameObject;
        // cube1.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}