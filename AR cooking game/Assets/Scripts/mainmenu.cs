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

    public void finish()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Level1()
    {
        SceneManager.LoadScene("amelia");
    }

    public void Level2()
    {
        SceneManager.LoadScene("recipetwo");
    }

    public void Level3()
    {
        SceneManager.LoadScene("recipethree");
    }

    public void Level4()
    {
        SceneManager.LoadScene("recipefour");
    }
}
