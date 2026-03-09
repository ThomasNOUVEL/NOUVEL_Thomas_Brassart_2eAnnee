using UnityEngine;
using UnityEngine.AI;



public class PlayerMouvement : MonoBehaviour
{

    public Camera camera;
    public NavMeshAgent navMeshReference;

    private void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.point);
                navMeshReference.SetDestination(hit.point);
            }
        }

    }
}
