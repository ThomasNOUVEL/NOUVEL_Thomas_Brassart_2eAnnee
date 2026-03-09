using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{

    public Camera Camera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RaycastHit hit;
        Ray ray = Camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit);
        }

    }
}
