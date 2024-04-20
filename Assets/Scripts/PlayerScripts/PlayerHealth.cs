using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : Health
{
    [SerializeField] private GameObject[] _hearts;
    
    private void Awake()
    {
        Initialize(3);

        foreach (var heart in _hearts)
        {
            heart.SetActive(true);
        }
    }

    private void Update()
    {
        Death();
    }
    
    public override void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        _hearts[CurrentHealth].SetActive(false);
    }

    public override void Death()
    {
        if (CurrentHealth <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
