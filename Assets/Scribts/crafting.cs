using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using inventory.Model;

public class crafting : MonoBehaviour
{
    [SerializeField] GameObject finishedCanvas;
    [SerializeField] GameObject akhirCanvas;
    [SerializeField] string level;
    public InventorySO inventory;


    private void OnTriggerEnter2D(Collider2D other)
    {
        Time.timeScale=0;
        if (inventory.IsInventoryFull())
        {
            SceneManager.LoadScene("crafting" + level);
            Debug.Log("udah full");
        } else {
            Debug.Log("belum full");
            finishedCanvas.SetActive(true);
        }


    }
     public void nextlevel()
    {
        SceneManager.LoadScene("LEVEL2");
    }
}
