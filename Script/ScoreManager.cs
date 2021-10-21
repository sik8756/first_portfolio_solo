using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    
    public static float score;
    public static int score2;
    public static int Coin;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Startbut()
    {
        SceneManager.LoadScene("Game");
    }

    public void Quitbut()
    {
        SceneManager.LoadScene("GameLobby");
    }

    public void QuitLobby()
    {
        Application.Quit();
    }
    public void reset()
    {
        
        SceneManager.LoadScene("Game");
        score = 0;
        
    }
}
