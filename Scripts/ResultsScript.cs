using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultsScript : MonoBehaviour
{
    public Text result;
    private static int currentScore;
    private static int hScore;
    // Update is called once per frame
    void Update()
    {
        currentScore = ObstacleScript.playerScore;
        hScore = ObstacleScript.highScore;
        string s = currentScore.ToString();
        string h = hScore.ToString();
        result.text = "Score : " + s + "\n" + "High Score : " + h;
    }
}
