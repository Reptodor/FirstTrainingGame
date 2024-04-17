using TMPro;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Walking")]
    [SerializeField] private float _speed;
    private float _moveHorizontal;
    private int _yRotation = 0;

    [Header("Jumping")] 
    [SerializeField] private float _jumpForce;
    
    
    [Header("GroundCheck")]
    [SerializeField] private LayerMask _groundLayer;
    [SerializeField] private float _playerHeight;
    private bool _grounded;
    
    
    private Rigidbody2D _rigidbody;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        GetAxis();
        Flip();
    }
    
    private void FixedUpdate()
    {
        Move();
        Jump();
    }

    private void GetAxis()
    {
        _moveHorizontal = Input.GetAxisRaw("Horizontal");
    }

    private void Flip()
    {
        if (_moveHorizontal > 0)
            _yRotation = 0;
        if (_moveHorizontal < 0)
            _yRotation = 180;
        transform.rotation = Quaternion.Euler(0, _yRotation, 0);
    }

    private bool GroundCheck()
    {
        _grounded = Physics2D.Raycast(transform.position, Vector2.down, _playerHeight, _groundLayer);
        return _grounded;
    }
    
    private void Move()
    {
        _rigidbody.velocity = new Vector2(_speed * _moveHorizontal, _rigidbody.velocity.y);
    }

    private void Jump()
    {
        if (GroundCheck() && Input.GetKey(KeyCode.Space))
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jumpForce);
        }
    }
}
