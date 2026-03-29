using UnityEngine;
using UnityEngine.Animations;

public class Spawner : MonoBehaviour
{
    
    [SerializeField] private Sphere _objectToSpawn;

    [SerializeField,Range(0.2f, 5)] private float _spawnDelay;

    [SerializeField] private LookAtConstraint _lookAtConstraintReference;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        _ = Spawn();
    }

    // Update is called once per frame
    void Update()
    {

    }

    async Awaitable Spawn()
    {
        while (true)
        {

            await Awaitable.WaitForSecondsAsync(_spawnDelay);

            Sphere fireBall = Instantiate(_objectToSpawn, transform.position, Quaternion.identity);

            fireBall.LookAtConstraintReference = _lookAtConstraintReference;
        }
    }


}
