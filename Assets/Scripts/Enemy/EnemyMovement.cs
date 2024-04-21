using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private GameObject[] _waypoints;
    [SerializeField] private float _speed;
    private int _currentWaypointIndex = 0;
    private int _nextWaypointIndex = 1;

    public void FixedUpdate()
    {
        Move();
        ChooseWaypoint();
    }
    
    private void Move()
    {
        transform.position =
            Vector3.MoveTowards(transform.position, _waypoints[_currentWaypointIndex].transform.position, _speed);
    }

    private void Flip()
    {
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
    
    private void ChooseWaypoint()
    {
        if (!(transform.position.x > _waypoints[0].transform.position.x &&
              transform.position.x < _waypoints[1].transform.position.x))
        {
            if (_nextWaypointIndex == _waypoints.Length)
            {
                _nextWaypointIndex = 0;
            }
            Flip();
            _currentWaypointIndex = _nextWaypointIndex;
            _nextWaypointIndex++;
        }
        
        
    }
}
