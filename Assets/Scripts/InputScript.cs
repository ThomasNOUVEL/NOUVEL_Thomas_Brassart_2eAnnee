using UnityEngine;
using UnityEngine.InputSystem;

public class InputScript : MonoBehaviour
{

    public void Shoot(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Debug.Log("Performed");
        }

        if (context.started)
        {
            Debug.Log("Started");
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
