using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Ball _objectToSpawn;

    [SerializeField, Range(0.2f, 5)] private float _spawnDelay;

    [SerializeField] private LookAtConstraint _lookAtConstraintReference;


    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Ball fireBall = Instantiate(_objectToSpawn, transform.position, Quaternion.identity);

            fireBall.LookAtConstraintReference = _lookAtConstraintReference;
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
