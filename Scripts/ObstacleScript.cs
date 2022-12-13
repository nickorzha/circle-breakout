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
        playerScore = 0; // Resetting the score for new game
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        playerScore++; // Increasing the score as each obstacle is hit
        highScore = Mathf.Max(playerScore, highScore); // Calculating high score
        Destroy(gameObject);
    }
}
