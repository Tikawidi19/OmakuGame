using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Button[] button;
    int Unlockeds;

    private void Start()
    {
            Unlockeds = PlayerPrefs.GetInt("Unlockeds", 1);
            for(int i = 0; i < button.Length; i++)
            {
                button[i].interactable = false;
                Debug.Log("gak nyala");
            }
            for (int i = 0; i < Unlockeds; i++)
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
    //int levelsUnlocked;
    ////public Button buttonLevel2;
    //// public Button buttonLevel3;
    
    //
    //void Start()
    //{
    //    levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked", 1);
    //    for(int i = 0; i < button.Length; i++)
    //    {
    //        button[i].interactable = false;
    //    }
    //    for (int i = 0; i < levelsUnlocked; i++)
    //    {
    //        button[i].interactable = true;
    //    }
    //}
    //public void loadLevel(int levelIndex)
    //{
    //    SceneManager.LoadScene(levelIndex);
    //}
    //public void CheckLevel()
    //{
    //    int statusLevel2 = PlayerPrefs.GetInt("Level2");
    //    int statusLevel3 = PlayerPrefs.GetInt("Level3");
    //
    //    if (statusLevel2 == 1)
    //        buttonLevel2.interactable = true;
    //    else
    //        buttonLevel2.interactable = false;
    //
    //    if (statusLevel3 == 1)
    //        buttonLevel3.interactable = true;
    //    else
    //        buttonLevel3.interactable = false;
    //}



    //Level2 
    //Level3
    //1 == Unlock
    //0 == Lock
}
