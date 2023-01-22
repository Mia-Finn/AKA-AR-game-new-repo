using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(0);
    }
    public void Level1()
    {
        SceneManager.LoadScene(3);
    }

    public void Level2()
    {
        SceneManager.LoadScene(6);
    }

    public void Level3()
    {
        SceneManager.LoadScene(9);
    }

    public void Level4()
    {
        SceneManager.LoadScene(12);
    }
}
