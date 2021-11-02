using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public Text txt;
    private static int score;
   
    void Update()
    {
        score = ObstacleScript.playerScore;
        string s = score.ToString();
        txt.text = s;
        
        //Debug.Log(score);
    }
}
