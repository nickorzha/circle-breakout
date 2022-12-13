using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public GameObject ball;
    public GameObject topPrefab;
    public GameObject bottomPrefab;
    private float timer1 = 0f;
    private float timer2 = 0f;
    public float waitingTime = 3f;

    // Update is called once per frame
    void Update()
    {
        // Respawning the top set of obstacles after all of them get hit
        if (GameObject.Find("TopObstacles(Clone)") == null && GameObject.Find("TopObstacles") == null)
        {
            timer1 += Time.deltaTime;
            if (timer1 > waitingTime)
            {
                Instantiate(topPrefab, new Vector3(0, 4, 0), Quaternion.identity);
                timer1 = 0f;
            }
        }
        // Respawning the bottom set of obstacles after all of them get hit
        if(GameObject.Find("BottomObstacles(Clone)") == null && GameObject.Find("BottomObstacles") == null)
        {
            timer2 += Time.deltaTime;
            if(timer2 > waitingTime)
            {
                Instantiate(bottomPrefab, new Vector3(0, -4, 0), Quaternion.identity);
                timer2 = 0f;
            }
        }
    }

    
    // Checking for collision of ball with the center platform
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(ball); // If collision occurs, game is over
        SceneManager.LoadScene("SampleScene 1");

    }
}
