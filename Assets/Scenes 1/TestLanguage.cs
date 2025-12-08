using UnityEngine;

public class TestLanguage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        const int MAX_HEALTH_POINTS = 25

        int healthPoints = 10;

        int potionHealPoint = 5;

        int damagePoint = 5;

        bool inLife = true;

        string playerName = "XxSuperKiller34xX";

        string playerName += $" {healthPoints}"; // ajoute une variable numérique à un text.

        (potionHealPoint, healthPoints) = (healthPoints, potionHealPoint); // inverse les valeurs sans prendre en compte des changement de la deuxième variable tant que la procédure n est pas fini.

        var manaPoint = 10; // atribue la variable dans le thype le plus logique en fonction de l'affectation ici 10 est un entier donc var va faire comme int.





        



        // hqgfq




    }

    int Increment(int value) // int informe que le return va etre un entier
    {
        return value + 1;
    }



    int Heal(int health, int potion = 5) // int health, int potion    informe que la fonction demande deux entiers pour faire ses calcules. Ici, "potion" = 10 si il n est pas spécifié à l'appel.
    {
        if health += potion > MAX_HEALTH_POINTS
                health = MAX_HEALTH_POINTS;
        else
            health += potion;
        return health;
    }



    (int, bool) Damage(int health, int Dgt, bool Life = true) // (int, bool)    informe que le return est un entier et un booléun    et     int health, int Dgt, bool Life     informe que la fonction demande deux entiers et un booléun pour faire ses calcules
    {
        if health -= dDgt < 0
                health = 0
                Life = false;
            else
            health -= Dgt;
        return (health, Life)
        }



    void CreerVar(out int Variable) // void    informe que le return sera vide    et     out informe que la variable sera créer dans cette fonction mais sera accessible en dehors
    {
        int Variable = 200
                return
        }

}
