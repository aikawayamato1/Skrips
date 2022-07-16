using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenus()
    {
        SceneManager.LoadScene(0);
    }
    public void Level1()
    {
        SceneManager.LoadScene(2);
    }
    public void Level2()
    {
        SceneManager.LoadScene(3);
    }
    public void Test()
    {
        SceneManager.LoadScene(4);
    }
    public void Testing()
    {
        SceneManager.LoadScene(5);
    }
    public void Quiz2()
    {
        SceneManager.LoadScene(8);
    }
    public void Quiz()
    {
        SceneManager.LoadScene(7);
    }
    public void Test2()
    {
        SceneManager.LoadScene(6);
    }
}
