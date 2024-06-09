using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlyerManager : MonoBehaviour
{

    public float speed = 5f;
    private float jumpingPower = 7f;
    private bool isfacingRight = true;
    private AudioManager AudioManager;
    public float groundCheckRadius = 0.2f;



    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    [SerializeField] AudioSource audioManager;
    [SerializeField] public GameObject AwalCanvas;
     private bool isGrounded;
    void Update()
    {
         if (isGrounded && Input.touchCount > 0)
        {
            Debug.Log("touch");
            // Loop melalui semua sentuhan yang terjadi pada saat ini
            for (int i = 0; i < Input.touchCount; i++)
            {
                // Jika sentuhan tersebut baru saja dimulai (tap)
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    Jump();
                    break; // Keluar dari loop setelah menemukan satu sentuhan yang baru dimulai
                }
            }
        }
        if (AwalCanvas==false){
            speed = 5f;
            Debug.Log("d");
        }
    }
    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

    }

    private void Start()
    {
        audioManager.Play();
        AwalCanvas.SetActive(true);
        
        
        rb = GetComponent<Rigidbody2D>();
         if (AwalCanvas==true)
        {
            Time.timeScale = 0;
            Debug.Log("d");
        }
    }

}