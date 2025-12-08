using UnityEngine;

public class Exercice : MonoBehaviour
{

    [SerializeField]
    private int _starTriangleSize = 2;
    [SerializeField]
    private int _userAge = 2;
    [SerializeField]
    private int _factorialValue = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        CheckUserAge(_userAge);

        DrawTriangle(_starTriangleSize);

        PrintFactorial(_factorialValue);

    }

    void CheckUserAge(int _userAge)
    {
        if (_userAge <= 0)
        {
            Debug.Log("vous n'êtes pas née");
        }
        else if(_userAge < 18)
        {
            Debug.Log("vous êtes mineur");
        }
        else
        {
            Debug.Log("vous êtes majeur");
        }
    }

    void DrawTriangle(int _starTriangleSize)
    {
        if (_starTriangleSize <= 0)
        {
            Debug.Log("entiez un entier positif pls");
        }
        else
        {

            int space = _starTriangleSize;
            string affichage = "";

            for (int ligne = 0; ligne <= _starTriangleSize; ligne++)
            {

                space = _starTriangleSize - (ligne + 1);

                for (int text = 0; text <= space + ligne * 2 - 1 ; text++)
                {
                    if (text > space)
                    {
                        affichage = affichage + "*";
                    }
                    else
                    {
                        affichage = affichage + " ";
                    }

                }

                affichage = affichage + "\n";
            }

            Debug.Log(affichage);

        }

    }


    void PrintFactorial(int _factorialValue)
    {
        int resultat = _factorialValue;
        for (int incrément = _factorialValue - 1; incrément > 0; incrément--)
            resultat = resultat * incrément;
        Debug.Log(resultat);
    }




}
