using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healty : MonoBehaviour
{
    public static int maxhealth = 3;
    public Image[] healthBar;
    public Sprite emptyHeart;
    public Sprite fullHeart;

    void Awake()
    {
        maxhealth = 3;
    }

    void Update()
    {
        foreach (Image img in healthBar)
        {
            img.sprite = emptyHeart;
        }

        for (int i = 0; i < maxhealth; i++)
        {
            healthBar[i].sprite = fullHeart;
        }
    }
}
