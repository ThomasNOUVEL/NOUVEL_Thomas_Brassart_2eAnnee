using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysCollectionsEnumsExercice : MonoBehaviour
{

    [SerializeField]
    private string[] Array1 = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };

    [SerializeField]
    private int ArraySize = 10;

    [SerializeField]
    private CollectionType Type = CollectionType.Array;

    [SerializeField]
    private Day Days = Day.Monday;


    ICollection collection;


    [ContextMenu("ResetArrayToArraySize")]
    void ResetArrayToArraySize()
    {
        Array.Resize(ref Array1, ArraySize);
    }

    [ContextMenu("ShowCollection")]
    void ShowCollection()
    {
        foreach (int i in collection)
        {
            Debug.Log(i);
        }
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        switch (Type)
        {
            case CollectionType.Array:
                collection = new int[5];
                break;

            case CollectionType.List:
                collection = new List<int>(6);
                break;

            case CollectionType.Stack:
                collection = new Stack<int>(7);
                break;

            case CollectionType.Queue:
                collection = new Queue<int>(8);
                break;


        }


        Debug.Log(Days);









    }

    
}

