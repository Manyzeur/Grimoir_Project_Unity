using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceManager : MonoBehaviour
{
    [SerializeField] private GameObject _tutoInterface = null;
    private void Start()
    {
        Time.timeScale = 0;
    }

    public void PassedTuto()
    {
        _tutoInterface.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
    }

    private void OnEnable()
    {
        Cursor.visible = true;
    }

    private void OnDisable()
    {
        Cursor.visible = false;
    }

    public void QuitGame()
	{
        Application.Quit();
	}

    public void RestartGame()
	{
        SceneManager.LoadScene("Lvl01_TheForest");
        Time.timeScale = 1;
    }

    public void MainMenu()
	{
        SceneManager.LoadScene("MainMenu");
	}

    public void StartLevel()
    {
        SceneManager.LoadScene("Lvl01_TheForest");
	}

}
