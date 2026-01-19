using UnityEngine;

public class WallClass : MonoBehaviour, IDestructible
{

    public bool IsDestroy = false;

    public void DestroySelf()
    {
        throw new System.NotImplementedException();
    }
}
