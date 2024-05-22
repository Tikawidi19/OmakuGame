using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
using System.Collections.Generic;
public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject GameOver;
    public AudioSource BGM;
    private AudioManager AudioManager;
    //public object AudioManager { get; private set; }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            healty.maxhealth--; 
            if (healty.maxhealth <= 0)
            {
                GameOver.SetActive(true);
                
                //audio.Play();
                AudioManager.instance.Play("GameOver");
                gameObject.SetActive(false);
                BGM.Pause();
            }
            else
            {
                StartCoroutine(GetHurt());
            }
        }
        //if (collision.transform.tag == "Enemy2")
        //{
        //    healty.maxhealth=-3;
        //    if (healty.maxhealth <= 0)
        //    {
        //        GameOver.SetActive(true);
        //        //PlyerManager.isGameOver = true;
        //        //AudioManager.instance.Play("GameOver");
        //        gameObject.SetActive(false);
        //    }
        //    else
        //    {
        //        StartCoroutine(GetHurt());
        //    }
        //}
    }
    IEnumerator GetHurt()
    {
        Physics2D.IgnoreLayerCollision(7, 8);
        GetComponent<Animator>().SetLayerWeight(1, 1);
        yield return new WaitForSeconds(1);
        GetComponent<Animator>().SetLayerWeight(1, 0);
        Physics2D.IgnoreLayerCollision(7, 8, false);
    }
    //IEnumerator GetHurt2()
    //{
    //    Physics2D.IgnoreLayerCollision(7, 10);
    //    //GetComponent<Animator>().SetLayerWeight(1, 1);
    //    yield return new WaitForSeconds(3);
    //    //GetComponent<Animator>().SetLayerWeight(1, 0);
    //    Physics2D.IgnoreLayerCollision(7, 10, false);
    //}
}
