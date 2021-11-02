using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleScript : MonoBehaviour
{
    public static int playerScore;
    public static int highScore;
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        playerScore = 0;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        playerScore++;
        highScore = Mathf.Max(playerScore, highScore);
        Destroy(gameObject);
    }
}
