using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Button[] button;
    int BukaLevel;

    private void Start()
    {
            BukaLevel = PlayerPrefs.GetInt("BukaLevel", 1);
            for(int i = 0; i < button.Length; i++)
            {
                button[i].interactable = false;
                Debug.Log("gak nyala");
            }
            for (int i = 0; i < BukaLevel; i++)
            {
                button[i].interactable = true;
                Debug.Log("gak nyala");
            }
    }
    public void OpenLevel(int LevelId)
    {
        string levelName = "Level" + LevelId;
        SceneManager.LoadScene(levelName);
        Debug.Log("untuk nyala");
    }

}
