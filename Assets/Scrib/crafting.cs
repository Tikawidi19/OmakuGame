using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class crafting : MonoBehaviour
{
    [SerializeField] GameObject finishedCanvas;
    [SerializeField] GameObject akhirCanvas;
    [SerializeField] string level;

    //[SerializeField] TMP_Text finishedText;

    //int coin = 10;
    //public void GameOver()
    //{
    //    finishedText.text = "Lose \n Try Again";
    //    finishedCanvas.SetActive(true);
    //    Debug.Log("GameOver");
    //}
    //public void Playerwin()
    //{
    //    finishedText.text = "You Win \nScore " + GetScore();
    //    finishedCanvas.SetActive(true);
    //    Debug.Log("PlayerWin");
    //}
    //
    //private int GetScore()
    //{
    //    return coin * 10;
    //}
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("crafting" + level);

      //  akhirCanvas.SetActive(true);
        //Debug.Log("Crafting");

    }
     public void nextlevel()
    {
        SceneManager.LoadScene("LEVEL2");
    }
}
