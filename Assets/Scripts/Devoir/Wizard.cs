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

    private new void Moove()
    {

        // déplacement ZQSD
        
    }

    private void Fireball()
    {

        // lance une boule de feu qui renvoie une liste : ListFireBallComponentCast qui recoeuil les éléments touchées
        // détruit tout les éléments de ListFireBallComponentCast qui ont l'iterface IDestructible

    }

}