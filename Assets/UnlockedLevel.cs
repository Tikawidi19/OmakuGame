using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnlockedLevel : MonoBehaviour
{
    public void unlocked()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        if(currentLevel >= PlayerPrefs.GetInt("Unlockeds"))
                {
                    //PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex+1);
                    PlayerPrefs.SetInt("Unlockeds", PlayerPrefs.GetInt("Unlockeds",1) + 1);
                    PlayerPrefs.Save();
                    
                }SceneManager.LoadScene("LevelStage");
        Debug.Log("LEVEL" + PlayerPrefs.GetInt("Unlockeds") + " Unlocked");
    }
}
