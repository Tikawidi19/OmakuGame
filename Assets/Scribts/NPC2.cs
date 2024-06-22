using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NPC2 : MonoBehaviour
{
        


    //public bool playerIsClose;
    //public GameObject button;
public Pickup pause;
public NPC teks;
public GameObject colider;
    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D other)
    {
        teks.dialoguePanel.SetActive(true); 
         pause.PauseGame();
           
        
    }
        public void close()
    {
        
       pause.ResumeGame();
       teks.dialoguePanel.SetActive(false); 
       colider.SetActive(false);
       
    }
}

   
