using UnityEngine;
using UnityEngine.Animations;

public class Sphere : MonoBehaviour
{

    [SerializeField,Min(50)] private int _speed = 50;

    [SerializeField,Min(2)] private float _lifeTime = 2f;

    private LookAtConstraint _lookAtConstraintReference;
    public LookAtConstraint LookAtConstraintReference
    {
        set
        {
            _lookAtConstraintReference = value; 
        }
    }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
    async Awaitable Start()
    {


        _lookAtConstraintReference.// AddSource;

        await Awaitable.WaitForSecondsAsync(_lifeTime);

        Destroy(gameObject);

    }

    

    // Update is called once per frame
    void Update()
    {
        
        transform.position = transform.position + Vector3.right /5 * _speed * Time.deltaTime;

        
    }
}
