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
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            
            if (dialoguePanel.activeInHierarchy)
            {
                
                zerotext();
                Time.timeScale = 0;

            }
            else
        {
                
                dialoguePanel.SetActive(true);
            StartCoroutine(Typing());

        }
        }
        if (dialogueText.text == dialogue[index])
        {
            NextLine();
            //button.SetActive(true);
        }


    }




    public void zerotext()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    //IEnumerato Typing()
    //{
    //    foreach (char letter in dialogue[index].ToCharArray())
    //    {
    //        dialogueText.text += letter;
    //        yield return new WaitForSeconds(wordSpeed);
    //    }
    //}

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
        //button.SetActive(false);
        if(index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zerotext();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            zerotext();
        }
    }
}
