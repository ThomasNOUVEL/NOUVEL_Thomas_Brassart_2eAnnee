using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Input_ZQSD_Shoot : MonoBehaviour
{
    private Vector2 _movement = Vector2.zero;

    [SerializeField] private float _movementSpeed = 5;


    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _movement = context.ReadValue<Vector2>() * _movementSpeed;
        }
        if (context.canceled)
        {
            _movement = Vector2.zero;
        }    

    }

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {

        transform.position += (Vector3)_movement * Time.deltaTime;
        float movementX = Mathf.Clamp(transform.position.x, -13, 13);
        float movementY = Mathf.Clamp(transform.position.y, -10, 10);
        transform.position = new Vector2(movementX, movementY);

    }
}
