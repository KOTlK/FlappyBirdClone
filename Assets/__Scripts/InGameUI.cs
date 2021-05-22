using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{
    private static Text _score;
    private static Canvas _mainMenu;
    private static Canvas _deathMenu;
    

    private void Awake()
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            GameObject child = transform.GetChild(i).gameObject;
            
            if (child.name == "InGameInfo")
            {
                _score = child.GetComponentInChildren<Text>();
            }
            else if (child.name == "MainMenu")
            {
                _mainMenu = child.GetComponent<Canvas>();
            }
            else if (child.name == "DeathMenu")
            {
                _deathMenu = child.GetComponent<Canvas>();
            }

        }

    }


    public static void UpdateScore(int score)
    {
        _score.text = $"Score: {score}";
    }

    public static void ShowMainMenu()
    {
        _mainMenu.enabled = true;
    }

    public static void HideMainMenu()
    {
        _mainMenu.enabled = false;
    }

    public static void ShowDeathMenu()
    {
        _deathMenu.enabled = true;
    }

    public static void HideDeathMenu()
    {
        _deathMenu.enabled = false;
    }
}
