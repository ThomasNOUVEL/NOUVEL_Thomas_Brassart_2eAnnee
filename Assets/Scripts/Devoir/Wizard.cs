using UnityEngine;

public class Wizard : CharacterClass
{

    

    private void Start()
    {

        HealthMax = 120;

        Health = HealthMax;

        Name = "Bernard Le Sage";

        int ManaMax = 200;

        int Mana = ManaMax;

    }

    public void Moove()
    {

        // déplacement ZQSD
        
    }

    private void Fireball(IDestructible ListFireBallComponentCast)
    {

        // détruit tout les éléments de ListFireBallComponentCast

    }

}