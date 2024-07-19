using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using inventory.Model;

public class PlyerManager : MonoBehaviour
{
    //Keperluan inventory
    public InventorySO inventory;

    //keperluan move
    public float speed = 5f;
    public float jumpingPower = 7f;
    private bool isfacingRight = true;

    public float groundCheckRadius = 0.2f;




    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    private bool isGrounded;


    //Keperluan informasi tutorial
    [SerializeField] AudioSource audiotutorial;
    [SerializeField] public GameObject AwalCanvas;
    [SerializeField] Button tombolLanjut;

    //Animasi
    private Animator animator;
    

    void Update()
    {
        
        if (AwalCanvas.activeSelf == true)// jika variabel awalCanvas hidup
        {
            //Debug.Log("hidup");
            Time.timeScale = 0; // pause
            if (!audiotutorial.isPlaying && audiotutorial.time > 0) //jika audio tidak sedang berjalan dan waktu audio lebih dari 0
            {
                // Aktifkan tombol
                tombolLanjut.gameObject.SetActive(true);
               // Debug.Log("tombol aktif");
            }
        }else {
            Time.timeScale = 1;
        //Debug.Log("mati");
        if (isGrounded && Input.touchCount == 1) // apakah player penyentuh platform dan apakah ada sentuhan
        {      
           // Debug.Log("touch");
            // Loop melalui semua sentuhan yang terjadi pada saat ini
            for (int i = 0; i < Input.touchCount; i++)
            {
                // Jika sentuhan tersebut baru saja dimulai (tap)
                if (Input.GetTouch(i).phase == TouchPhase.Began) // manggil klas jump jika ada sentuhan untuk pertama kali
                {
                    Jump();
                    
                    break; // Keluar dari loop setelah menemukan satu sentuhan yang baru dimulai
                }
            }
        }  
        animator.SetBool("isJumping", !isGrounded); //manggil animasi
        animator.SetBool("isRun", isGrounded && rb.velocity.x != 0);
     }
         

    }
    void Jump()
    {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
    }

    private void FixedUpdate()
    {
        if (AwalCanvas.activeSelf==false)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
            
        }

    }

    private void Start()
    {

        AwalCanvas.SetActive(true);
        inventory.ResetInventory();
        tombolLanjut.gameObject.SetActive(false);
        animator= GetComponent<Animator>();
        
        rb = GetComponent<Rigidbody2D>();

    }
       

}