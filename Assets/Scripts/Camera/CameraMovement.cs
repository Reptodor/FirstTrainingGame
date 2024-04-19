using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _player;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var position = _player.transform.position;
        transform.position = new Vector3(position.x, position.y, transform.position.z);
    }
}
