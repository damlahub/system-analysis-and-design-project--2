using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene(2);
    }

    public void HowtoplayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }

    public void Level1()
    {
        SceneManager.LoadScene(3);
    }
    public void Lv1Refresh()
    {
        SceneManager.LoadScene(4);
    }

    public void Lvls()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
