using UnityEngine;
using UnityEngine.UIElements;

public class GoblinClass : CharacterClass, IDestructible
{

    protected Vector3 StartWalkVector = Vector3.zero;

    protected Vector3 EndWalkVector = Vector3.zero;

    private void Start()
    {

        HealthMax = 50;

        Health = HealthMax;

        Name = "PasBernard";

    }

    public void MooveBetween()
    {

        // Alterne entre MooveTo(StartWalkVector); et MooveTo(EndWalkVector);

    }

    public void DestroySelf()
    {
        // Auto destruction
    }
}

