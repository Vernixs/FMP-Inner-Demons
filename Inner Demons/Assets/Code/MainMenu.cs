using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string firstLevel;

    public GameObject optionsScreen;
    public GameObject mainScreen;
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void StartGame ()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenOptions()
    {
        optionsScreen.SetActive(true);
        mainScreen.SetActive(false);

    }

    public void CloseOptions()
    {
        optionsScreen.SetActive(false);
        mainScreen.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("works");
    }
}
