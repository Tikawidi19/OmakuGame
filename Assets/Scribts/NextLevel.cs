﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void Pass()
    {
                  if(SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
                {
                    PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
                    PlayerPrefs.SetInt("Open", PlayerPrefs.GetInt("Open", 1) + 1);
                    PlayerPrefs.Save();
                    
                }SceneManager.LoadScene("LevelStage");
        Debug.Log("level" + PlayerPrefs.GetInt("Open") + " UnlockedNext");
    }
}
