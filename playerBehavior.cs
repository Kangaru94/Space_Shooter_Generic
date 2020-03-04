using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playerBehavior : MonoBehaviour
{
    private float horizontalInput;
    private int playerSpeed = 30;
    private int leftBound = -43;
    private int rightBound = 27;
    private int zBound = 50;
    private int yBound = -23;
 

    public GameObject projectileAsset;


// Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
        // Keeps the player in bounds of the playing screen
        // Calls KeepInBounds function
        KeepInBounds();

        ShootProjectile();

    }

    void ShootProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectileAsset, transform.position, projectileAsset.transform.rotation);
        }

    }
    void KeepInBounds()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * -horizontalInput);

        if (transform.position.x > rightBound)
        {
            transform.position = new Vector3(rightBound, transform.position.y, transform.position.z);
        }

        if (transform.position.x < leftBound)
        {
            transform.position = new Vector3(leftBound, transform.position.y, transform.position.z);
        }

        if (transform.position.z != 50)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }

        if (transform.position.y != -23)
        {
            transform.position = new Vector3(transform.position.x, yBound, transform.position.z);
        }

    }
}
