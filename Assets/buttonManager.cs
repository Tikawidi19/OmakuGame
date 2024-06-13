using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonManager : MonoBehaviour
{
    [SerializeField] private Button tombol;
    [SerializeField] private AudioSource AudioInfor;
    // Start is called before the first frame update
    void Start()
    {
        tombol.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(!AudioInfor.isPlaying && AudioInfor.time > 0)
        {
            tombol.gameObject.SetActive(true);
        }
    }
}
