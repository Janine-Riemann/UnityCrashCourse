using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Vector2 _playerMovement;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private SpriteRenderer _playerSprite;

     // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerSprite = GetComponent<SpriteRenderer>();
    }
   
    public void OnMove(InputAction.CallbackContext context)
    {
        _playerMovement = context.ReadValue<Vector2>();
        _playerMovement.y = 0;
      
    }

    // Update is called once per frame
    void Update()
    {
        if(_playerMovement.x < 0)
        {
            _playerSprite.flipX = true;
        }
        if(_playerMovement.x > 0)
        {
            _playerSprite.flipX = false;
        }

        transform.Translate(_speed * Time.deltaTime * _playerMovement);
    }
}
