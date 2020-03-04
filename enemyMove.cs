using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    private int enemySpeed = 25;
    private int zBound = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * enemySpeed);

        if (transform.position.z != 50)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
    }
}
