using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void callSceneMainGame()
    {
        SceneManager.LoadScene(1);
    }
    public void callSceneCredits()
    {
        SceneManager.LoadScene(2);
    }
    public void callSceneMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void callExitApp()
    {
        Application.Quit();
    }
}
