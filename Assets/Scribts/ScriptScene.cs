using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptScene : MonoBehaviour
{

    public void PindahScene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}