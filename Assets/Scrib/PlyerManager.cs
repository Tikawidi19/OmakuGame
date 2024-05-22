using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlyerManager : MonoBehaviour
{
    //public float horizontal;
    public float speed = 5f;
    private float jumpingPower = 10f;
    private bool isfacingRight = true;
    private AudioManager AudioManager;
    public float groundCheckRadius = 0.2f;
    //public Animator animator;
    //public Animator animator;


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    //[SerializeField] Image healthBar;
    //[SerializeField] int currentHp;
    //[SerializeField] int maxHP;
    [SerializeField] AudioSource audioManager;
    [SerializeField] public GameObject AwalCanvas;
     private bool isGrounded;
    //public static int NumberOfCoins;
    //public TextMeshProUGUI coinsText; 

    // Update is called once per frame
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

        // if (AwalCanvas == false){
        //     speed = 3f;
        //     Debug.Log("jalan");
        // }
        // else{
        //     speed = 0f;
        //     Debug.Log("diam");
        // }
        //AudioManager.instance.Play("Play");
        //coinsText.text ="Coins: " + NumberOfCoins;
        // horizontal = Input.GetAxisRaw("Horizontal");
        // //Debug.Log("Jalan");

        // if(Input.GetButtonDown("Jump") && isGrounded())
        // {
        //     rb.velocity = new Vector2(rb.velocity.x, jumpingPower);

            
        // }
        // if (Input.GetButtonUp("Jump") && rb.velocity.y >0f)
        // {
        //     rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
            
        // }
        // Flip();
    }

    // private void Flip()
    // {
    //     if(isfacingRight && horizontal < 0f || !isfacingRight && horizontal >0f)
    //     {
    //         isfacingRight = !isfacingRight;
    //         Vector3 localScale = transform.localScale;
    //         localScale.x *= -1f;
    //         transform.localScale = localScale;
    //     }
    // }
        void Jump()
    {
        // Melompat
        rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
    }
    private void FixedUpdate()
    {
                rb.velocity = new Vector2(speed, rb.velocity.y);

        // Cek apakah karakter berada di tanah
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        // if(isGrounded == true)
        // {
        //     Debug.Log("ditanah");
        // } else{
        //     Debug.Log("diangkasa");
        // }
    }

    // private bool IsGrounded()
    // {
    //     return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    // }

    private void Start()
    {
        audioManager.Play();
        AwalCanvas.SetActive(true);
        
        
        rb = GetComponent<Rigidbody2D>();
         if (AwalCanvas==true){
            // speed = 0f;
            Time.timeScale = 0;
            Debug.Log("d");
        }
    }

    //public void ChangeHP(int amount)
    //{
    //    currentHp += amount;
    //    // if (currentHp < 0)
    //    // {
    //    //     currentHp = 0;
    //    // }
    //    // if (currentHp > maxHP)
    //    // {
    //    //     currentHp = maxHP;
    //    // }
    //    currentHp = Mathf.Clamp(currentHp, 0, maxHP);
    //    UpdateHPUI();
    //}
    //private void UpdateHPUI()
    //{
    //    healthBar.fillAmount = (float)currentHp / (float)maxHP;
    //    //hpText.text = currentHp + "/" + maxHP;
    //
    //}


}
