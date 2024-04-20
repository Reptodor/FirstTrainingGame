using UnityEngine;

public abstract class Health : MonoBehaviour
{
    protected int CurrentHealth;
    
    protected Health() { }

    protected void Initialize(int healthAmount)
    {
        CurrentHealth = healthAmount;
    }
    
    public abstract void TakeDamage(int damage);

    public abstract void Death();
}
