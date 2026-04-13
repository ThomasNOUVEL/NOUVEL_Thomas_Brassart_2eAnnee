using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Input_ZQSD_Shoot : MonoBehaviour
{

    public void OnMoove(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

            Vector2 movement = context.ReadValue<Vector2>();
            Vector2 location = transform.position;
            Vector2 tryToMoove = location + movement;

            transform.position = tryToMoove;
        }

    }

    public void OnShoot(InputAction.CallbackContext context)
    {



    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector2 startLocation = transform.position;
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
