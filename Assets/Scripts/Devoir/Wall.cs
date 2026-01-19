using UnityEngine;

public class WallClass : MonoBehaviour, IDestructible
{

    public bool IsDestroy = false;

    public void DestroySelf()
    {
        // Auto destruction
    }
}
