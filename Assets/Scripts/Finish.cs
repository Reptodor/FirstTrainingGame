using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private int _nextNumberScene;
    public bool CanFinish = false;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerHealth>() != null && CanFinish)
        {
            SceneManager.LoadScene(_nextNumberScene);
        }
    }
}
