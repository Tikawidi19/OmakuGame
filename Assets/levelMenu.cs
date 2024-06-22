using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelMenu : MonoBehaviour
{
    public Button[] Button;
    private void Awake()
    {
            int UnlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);
            for(int i = 0; i < Button.Length; i++)
            {
                Button[i].interactable = false;
                Debug.Log("gak nyala");
            }
            for (int i = 0; i < UnlockedLevel; i++)
            {
                Button[i].interactable = true;
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