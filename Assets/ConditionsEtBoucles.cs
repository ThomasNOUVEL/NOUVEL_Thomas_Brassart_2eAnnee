using UnityEngine;

public class ConditionsEtBoucles : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // || = or          true || true = true        true || false = true        false || false = false
        // && = and         true && true = true        true && false = false       false && false = false
        // ^  = xor         true ^ true = false        true ^ false = true         false ^ false = false
        // !  = not         !true = false              !false = true
        // ?? = est il null ?                          6 ?? = false                null ?? = true

        bool variable = true;
        if (variable)                    // if (Booléen) entre parentaises suis à la ligne + accolades
        {
            
        }

        int entier = 3;

        switch (entier)                 // comme un switch unreal, on entre un entier entre parentaises
        {
            case 0:                     // comme dans unreal sorties 0, 1, 2, ...
                Debug.Log(entier + 10); // Debug.Log() = print mais en C#
                break;

            case 1:
                print(entier + 20);
                break;

            case 3:
                print(entier + 30);
                break;

            case >= 10:                 // ici par contre un cas peut etre un calcul
                print(entier + 40);
                break;

            default:                    // et une sortie default au cas ou
                print(entier);
                break;

        }

        bool player = true;
        playerCount = player ? 1 : 0;   // if player = true: playerCount = 1        else: playerCount = 0


        string playerName = null;
        playerName = playerName ?? "none";




        // Les boucles


        // while (condition)                        bon ça tu connais

        // for ( var ; condition ; fin)             

        for (int i = 0; i < 10; i++)               // au lancement créé la variable i = 0 et tant que i < 10, lance le code dessou et à la fin effectue i++
        {
            if (i % 2 == 1)
            {
                continue;                         // continue fait passer imétiatement au prochain tour de boucle sans finir le code (effectue quand même le i++)
            }

        }









    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
