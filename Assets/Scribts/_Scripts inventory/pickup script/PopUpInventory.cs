using System.Collections;
using System.Collections.Generic;
using inventory.Model;
using inventory.UI;
using UnityEngine;

public class PopUpInventory : MonoBehaviour
{
    
    
    // [SerializeField] GameObject finishedCanvas;
    [SerializeField] GameObject akhirCanvas;
     private UIInventoryPage inventoryUI;
    private InventorySO inventoryData;

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
                  
        // //Time.timeScale=0;
        // inventoryUI.Show();
        //         foreach (var item in inventoryData.GetCurrentInventoryState())
        //         {
        //             inventoryUI.UpdateData(item.Key, item.Value.item.ItemImage, item.Value.quantity);
        //         }
        // // SceneManager.LoadScene("crafting");

       
                inventoryUI.Show();

        Debug.Log("Crafting");

    }
    
}

