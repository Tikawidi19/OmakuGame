
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    [SerializeField] private int value;
    [SerializeField] Image healthBar;
    private bool hasTriggered;
    private CoinMnager coinMnager;

    private void Start()
    {
        coinMnager = CoinMnager.instance;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;
            coinMnager.ChangeCoins(value);
            Destroy(gameObject);
        }
       

    }
}
