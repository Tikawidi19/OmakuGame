using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NPC2 : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public bool playerIsClose;
    private int index;
    public GameObject dialoguePanel;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialog();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {


            if (textComponent.text == lines[index])
            {

                NextLine();
                

            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];


            }
        }
    }
    void StartDialog()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);  
        }
    }
}
