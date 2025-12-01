using UnityEngine;

public class VariablesFunctionsExercise : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1. a.

        int tata = 5;
        int toto = 7;

        print(tata);
        print(toto);

        (toto, tata) = (tata, toto);

        print(tata);
        print(toto);

        // 1. b.

        int titi = 2;
        float tutu = 6.34;

        print(titi);
        print(tutu);

        (titi, tutu) = (tutu, float titi);

        print(titi);
        print(tutu);

        // 2.

        char tataEcrit = $" {tata}";

        print(tataEcrit);

        // 3.

        float Add(float A, float B)
        {
            return A + B;
        }

        var ResultatAdd = Add(3, 11);

        print(ResultatAdd);

        // 4.

        void Multiply(int A, int B,out int Resultat)
        {
            int Resultat = A * B;
            return;
        }

        Multiply(6, 7, ResultatMultiply);

        print(resultat);

        // 5;

        void IsMajor(int age);
        {
            Debug.Log(age >= 18);
        }

        IsMajor(7);

        IsMajor(27);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
