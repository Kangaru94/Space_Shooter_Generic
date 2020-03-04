using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPointScript : MonoBehaviour
{
    public GameObject spawner;
    private float spawnTime = 2.5f;
    private int leftBound = -43;
    private int rightBound = 27;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("enemySpawner", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void enemySpawner()
    {
        Vector3 spawnerPosition = new Vector3(Random.Range(leftBound, rightBound), 36, 50);

        Instantiate(spawner, spawnerPosition, spawner.transform.rotation);
    }
}
