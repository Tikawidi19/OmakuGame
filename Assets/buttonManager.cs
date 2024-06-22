using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonManager : MonoBehaviour
{
    [SerializeField] private Button tombol;
    [SerializeField] private AudioSource audioInfor;

void Start()
    {
        if (audioInfor != null)
        {
            Debug.Log("sound terdeteksi | putar audio");
            audioInfor.Play();
        }
        else
        {
            Debug.LogError("No AudioSource assigned!");
        }

        if (tombol != null)
        {
            Debug.Log("tombol ada & tidak aktif");
            tombol.gameObject.SetActive(false); // Pastikan tombol tidak aktif pada awalnya
        }
        else
        {
            Debug.LogError("No Button assigned!");
        }
    }

    void Update()
    {
        
        // Cek apakah suara telah selesai diputar
        if (audioInfor != null && !audioInfor.isPlaying && tombol != null && !tombol.gameObject.activeSelf)
        {
            Debug.Log("audio telah selesai di putar | tombol aktif");
            ActivateButton();
        }
    }

    void ActivateButton()
    {
        if (tombol != null)
        {
            tombol.gameObject.SetActive(true);
        }
    }
}















































































    // // Start is called before the first frame update
    // void Start()
    // {
    //     tombol.gameObject.SetActive(false);
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     Debug.Log(audioInfor.time);
    //     Debug.Log("Hot Control: " + GUIUtility.hotControl);
    //     //Debug.LogError("gak bisa ada yang eror");

    //     // Cek jika audio sudah habis diputar
    //     if (!audioInfor.isPlaying && audioInfor.time >= audioInfor.clip.length)
    //     {
    //         tombol.gameObject.SetActive(true);
    //         if (tombol.gameObject.activeSelf)
    //         {
    //             Debug.Log("Tombol lanjut informasi aktif");
    //         }
    //     }
    //     else
    //     {
    //         Debug.Log("Nggak mau ah");
    //     }
    // }
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class buttonManager : MonoBehaviour
// {
//     [SerializeField] private Button tombol;
//     [SerializeField] private AudioSource AudioInfor;
//     // Start is called before the first frame update
//     void Start()
//     {
//         tombol.gameObject.SetActive(false);
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         Debug.Log(AudioInfor.time);
//         if(!AudioInfor.isPlaying && AudioInfor.time > 0)
//         {
            
//             tombol.gameObject.SetActive(true);
//             if(tombol.gameObject.activeSelf)
//             {
//                 Debug.Log("tombol lanjut informasi aktif");
//             }
//         }else{
//             Debug.Log("nggak mau ah");
//         }
//     }
// }
