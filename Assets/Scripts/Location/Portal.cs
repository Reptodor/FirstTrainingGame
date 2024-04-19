using System;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private Transform _destination;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerMovement>() != null)
        {
            other.gameObject.transform.position = _destination.transform.position;
        }
    }
}
