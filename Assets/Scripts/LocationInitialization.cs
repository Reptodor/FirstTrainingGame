using UnityEngine;

public class LocationInitialization : MonoBehaviour
{
    [SerializeField] private GameObject[] _things;


    private void Awake()
    {
        Initialize();
        Destroy(this);
    }
    
    private void Initialize()
    {
        foreach (var thing in _things)
        {
            thing.SetActive(true);
        }
    }
}
