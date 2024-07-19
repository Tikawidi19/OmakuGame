using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnlockedLevel : MonoBehaviour
{
    public void unlocked()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        if(currentLevel >= PlayerPrefs.GetInt("BukaLevel"))
                {
                    //PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex+1);
                    PlayerPrefs.SetInt("BukaLevel", PlayerPrefs.GetInt("BukaLevel",1) + 1);
                    PlayerPrefs.Save();
                    
                }SceneManager.LoadScene("LevelStage");
        Debug.Log("LEVEL" + PlayerPrefs.GetInt("BukaLevel") + " UnlockedLevel");
    }
}
