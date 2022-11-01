using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceManager : MonoBehaviour
{
    void Start()
    {
               
    }

    void Update()
    {
        
    }

    public void QuitGame()
	{
        Application.Quit();
	}

    public void RestartGame()
	{
        SceneManager.LoadScene("PlayTestScene");
	}

    public void MainMenu()
	{
        SceneManager.LoadScene("MainMenu");
	}

    public void StartLevel()
    {
        SceneManager.LoadScene("PlayTestScene");
	}
}
