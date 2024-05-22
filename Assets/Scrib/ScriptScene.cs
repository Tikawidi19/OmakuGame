using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptScene : MonoBehaviour
{
    [SerializeField] GameObject[] Level;
    int characterIndex;
    private float speed = 8f;

    public void PindahScene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }
    //public void Awake()
    //{
    //    characterIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
    //    GameObject player = Instantiate(playerPrefabs[characterIndex], lastCheckPointPos, Quaternion.identity);
    //
    //}
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
