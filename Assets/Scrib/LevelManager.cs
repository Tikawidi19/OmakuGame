using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Button[] button;

    private void Awake()
    {
        int Unlockeds = PlayerPrefs.GetInt("Unlockedss", 1);
            for(int i = 0; i < button.Length; i++)
            {
                button[i].interactable = false;
            }
            for (int i = 0; i < Unlockeds; i++)
            {
                button[i].interactable = true;
            }
    }
    public void OpenLevel(int LevelId)
    {
        string levelName = "Level" + LevelId;
        SceneManager.LoadScene(levelName);
    }

}
