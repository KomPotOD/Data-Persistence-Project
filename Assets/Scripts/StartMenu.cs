using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void CurrentName(string name)
    {
        GameManager.S.currentName = name;
    }
    
    public void GameStart()
    {
        if(GameManager.S.currentName != null)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void GameQuit()
    {
        Application.Quit();
    }
}
