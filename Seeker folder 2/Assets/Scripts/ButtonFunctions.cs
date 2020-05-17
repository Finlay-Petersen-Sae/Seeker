using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{

    public GameObject Menu;
    public bool MenuUp;
    public string URL;

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void LoadScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenLink()
    {
        Application.OpenURL(URL);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        Menu.SetActive(false);
    }

    public void Update()
    {
        if (Menu != null && Input.GetKeyDown(KeyCode.Escape) && !MenuUp)
        {
            Time.timeScale = 0f;
            Menu.SetActive(true);
            MenuUp = true;
        }
        else if (Menu  != null && Input.GetKeyDown(KeyCode.Escape) && MenuUp)
        {
            Time.timeScale = 1f;
            Menu.SetActive(false);
            MenuUp = false;
        }
    }

}
