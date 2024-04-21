using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _coinCost = 1;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Wallet>() != null)
        {
            other.gameObject.GetComponent<Wallet>().AddCoin(_coinCost);
            Destroy(gameObject);
        }
    }
}
