using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{ 
        public float speed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float groundCheckRadius = 0.2f;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Pergerakan ke depan
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

    void Update()
    {
        // Jika karakter berada di tanah dan ada setidaknya satu sentuhan pada layar
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
    }

    void Jump()
    {
        // Melompat
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
    // public float speed = 5f;
    // public float jumpForce = 10f;
    // public Transform groundCheck;
    // public LayerMask groundLayer;
    // public float groundCheckRadius = 0.2f;

    // private Rigidbody2D rb;
    // private bool isGrounded;

    // void Start()
    // {
    //     rb = GetComponent<Rigidbody2D>();
    // }

    // void FixedUpdate()
    // {
    //     // Pergerakan ke depan
    //     rb.velocity = new Vector2(speed, rb.velocity.y);

    //     // Cek apakah karakter berada di tanah
    //     isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    //     if(isGrounded == true)
    //     {
    //         Debug.Log("ditanah");
    //     } else{
    //         Debug.Log("diangkasa");
    //     }
    // }

    // void Update()
    // {
    //     // Jika karakter berada di tanah dan player menekan tombol lompat
    //     if (isGrounded && Input.GetMouseButtonDown(0))
    //     {
    //         Debug.Log("lompat");
    //         Jump();
    //     }
    // }

    // void Jump()
    // {
    //     // Melompat
    //     rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    // }
}
