using System;
using System.Collections.Generic;
using UnityEngine;

public class TableauxCollections : MonoBehaviour
{
    [Flags]
    enum Day
    {
        Monday    = 1 << 0,
        Tuesday   = 1 << 1,
        Wednesday = 1 << 2,
        Thursday  = 1 << 3,
        Friday    = 1 << 4,
        Saturday  = 1 << 5,
        Sunday    = 1 << 6,
    }








    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] array = { 0, 10, 20, 30, 40, 50, 60, 100 };

        int index = array[3];                   // index = 7


        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);                // Affiche tout le tableau 1 par 1
        }


        List<int> entier = new(array);          // remplie la liste du tableau ( une liste peu etre remplie soit comme ça soit de façon brut avec des add )

        entier.Add(3);

        foreach (int i in entier)
        {
            Debug.Log(i);                // Affiche toute la liste 1 par 1
        }


        Dictionary<int, string> stringByInt = new();            // créé un dictionnaire vide

        stringByInt[1] = "salut";

        stringByInt[2] = "...";

        stringByInt[3] = "T'as un snap";

        stringByInt[4] = "Non";

        stringByInt[5] = "Je te dis que j ai un discord";

        stringByInt[6] = "C'est quoi ça ?!";

        if (stringByInt.TryGetValue(12, out string stringValue11) == false)             // TryGetValue regarde si la clée 12 est attribuée et renvoie un booéun, si il n existe pas, on entre dans le if
        {
            stringByInt[12] = "The cake is a lie";
        }



        int[,] TableauDeuxDimentions = new int[4, 6];                       // ici on créer un tableau à deux dimentions ( 4 par 6 )


        for (int i = 0; i < TableauDeuxDimentions.GetLength(0); i++)        // Travrse la dimention 0 du tableau ( 4 )
        {

        }


        Day myDay = Day.Thursday;                   // uttilisation de l'enum Day

        switch (myDay)
        {
            case Day.Thursday:
                Debug.Log(4);
                break;

            case Day.Friday:
                Debug.Log(5);
                break;

        }











    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
