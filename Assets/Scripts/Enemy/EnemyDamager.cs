using UnityEngine;

public class EnemyDamager : MonoBehaviour
{
    [SerializeField] private int _damage = 1;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerHealth>() != null)
        {
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(_damage);
        }
    }
}
