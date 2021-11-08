using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartFirstLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMainMenu()
    {
        GameSession gameSession = FindObjectOfType<GameSession>();
        if(gameSession != null)
        {
            Destroy(gameSession.gameObject);
        }
        SceneManager.LoadScene(0);
    }
}
