using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TMP_Text  dialogueText;
    public string[] dialogue;
    private int index;

    public float wordSpeed;
    public bool playerIsClose;
    public GameObject button;

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D other)
    {
   
           dialoguePanel.SetActive(true);
           Time.timeScale=0;
        
    }

    public void close()
    {
        dialoguePanel.SetActive(false);
        Time.timeScale=1;
    }
}
