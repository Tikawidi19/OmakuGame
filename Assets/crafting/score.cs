using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    public void Start()
    {
        score = GetComponent<Text>();

    }
    public void Update()
    {
        score.text = "score"+ scoreValue;
    }
    //private int score = 0;
    //
    //public void AddScore(int points)
    //{
    //    score += points;
    //    Debug.Log("Score increased by " + points + ". Total score: " + score);
    //}
    //
    //public void ResetScore()
    //{
    //    score = 0;
    //    Debug.Log("Score reset to 0.");
    //}
    //public Text scoreText; // Referensi ke teks UI yang menampilkan skor
    //private int score; // Variabel untuk menyimpan skor
    //
    //// Dipanggil saat permainan dimulai
    //private void Start()
    //{
    //    score = 0; // Set skor awal ke 0
    //    UpdateScoreText(); // Update teks skor
    //}
    //
    //// Dipanggil saat mendapatkan poin
    //public void AddScore(int points)
    //{
    //    score += points; // Tambahkan poin ke skor
    //    UpdateScoreText(); // Update teks skor
    //}
    //
    //// Update teks skor di UI
    //private void UpdateScoreText()
    //{
    //    scoreText.text = "Score: " + score.ToString();
    //}
}


