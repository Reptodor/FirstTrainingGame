using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : Health
{
    [SerializeField] private GameObject[] _hearts;
    [SerializeField] private int _currentNumberScene;
    [SerializeField] private int _healthAmount = 3;
    
    private void Awake()
    {
        Initialize(_healthAmount);

        foreach (var heart in _hearts)
        {
            heart.SetActive(true);
        }
    }
    
    public override void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        _hearts[CurrentHealth].SetActive(false);
        if (CurrentHealth <= 0) Death();
    }

    public override void Death() => SceneManager.LoadScene(_currentNumberScene);
    
}
