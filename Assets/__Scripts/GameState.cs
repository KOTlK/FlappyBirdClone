using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{

    private void Start()
    {
        Time.timeScale = 0;
        InGameUI.ShowMainMenu();
    }
    public static void StartGame()
    {
        Time.timeScale = 1;
        InGameUI.HideMainMenu();
        InGameUI.HideDeathMenu();
    }

    public static void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
        ScoreCounter.ResetScore();
        Time.timeScale = 0;
        InGameUI.ShowMainMenu();
    }

    public static void PauseOnDeath()
    {
        Time.timeScale = 0;
        InGameUI.ShowDeathMenu();
    }
}
