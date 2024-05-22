using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlyerManager : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 10f;
    private bool isfacingRight = true;
    private AudioManager AudioManager;
    //public Animator animator;
    //public Animator animator;


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    //[SerializeField] Image healthBar;
    //[SerializeField] int currentHp;
    //[SerializeField] int maxHP;
    [SerializeField] AudioSource audioManager;
    [SerializeField] GameObject AwalCanvas;
    
    //public static int NumberOfCoins;
    //public TextMeshProUGUI coinsText; 

    // Update is called once per frame
    void Update()
    {
        //AudioManager.instance.Play("Play");
        //coinsText.text ="Coins: " + NumberOfCoins;
        horizontal = Input.GetAxisRaw("Horizontal");
        //Debug.Log("Jalan");

        if(Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);

            
        }
        if (Input.GetButtonUp("Jump") && rb.velocity.y >0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
            
        }
        Flip();
    }

    private void Flip()
    {
        if(isfacingRight && horizontal < 0f || !isfacingRight && horizontal >0f)
        {
            isfacingRight = !isfacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Start()
    {
        audioManager.Play();
        AwalCanvas.SetActive(true);
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
