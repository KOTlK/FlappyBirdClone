using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private static int _currentScore;

    private void Awake()
    {
        ResetScore();
    }



    public static void UpdateScore()
    {
        _currentScore++;
        InGameUI.UpdateScore(_currentScore);
    }


    public static void ResetScore()
    {
        _currentScore = 0;
    }
    
}
