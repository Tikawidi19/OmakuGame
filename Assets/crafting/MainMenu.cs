using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void CRAFTING()
    {
        SceneManager.LoadScene("crafting");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    //public void ()
    //{
        //AwalCanvas.SetActive(true);
   // }
}
