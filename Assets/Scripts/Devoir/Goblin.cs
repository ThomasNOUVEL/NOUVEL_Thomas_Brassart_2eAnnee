using UnityEngine;
using UnityEngine.UIElements;

public class GoblinClass : CharacterClass, IDestructible
{

    

    private void Start()
    {

        HealthMax = 50;

        Health = HealthMax;

        Name = "PasBernard";

        Vector3 StartWalkVector = Vector3.zero;

    }

    private new void Moove()
    {

        // déplace de StartWalkVector jusqu'a EndWalkVector.
        // StartWalkVector devien EndWalkVector.

    }

    public void DestroySelf()
    {
        throw new System.NotImplementedException();
    }
}

