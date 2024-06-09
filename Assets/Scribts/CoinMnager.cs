using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinMnager : MonoBehaviour
{
    public static CoinMnager instance;
    private int Coin;
    [SerializeField] private TMP_Text coinsDisplay;
    [SerializeField] public TMP_Text final;
    private void Awake()
    {

        if(!instance)
        {
            instance = this;
        }
    }
    private void OnGUI()
    {
        coinsDisplay.text = Coin.ToString();
        final.text = Coin.ToString();

    }
    public void ChangeCoins(int amount)
    {
        Coin += amount;
    }
}
