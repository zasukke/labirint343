using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
    public GameObject setting;
    public GameObject main;

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Setting()
    {
        setting.SetActive(true);
        main.SetActive(false);
    }

    public void Back()
    {
        setting.SetActive(false);
        main.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
