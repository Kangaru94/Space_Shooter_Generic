using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDestroyer : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject highScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameOver.GetComponent<TextMesh>().text = $"Score: {scoreKeeping.score}";
        highScore.GetComponent<TextMesh>().text = $"High Score: {scoreKeeping.highScore}";

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);

        scoreKeeping.score++;

        if (scoreKeeping.score > scoreKeeping.highScore)
        {
            scoreKeeping.highScore = scoreKeeping.score;
        }

      gameOver.SetActive(true);
  
       
    }
}
