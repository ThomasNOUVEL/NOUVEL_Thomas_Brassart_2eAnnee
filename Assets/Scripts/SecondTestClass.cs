using UnityEngine;

public class SecondTestClass
{

    private FirstTestClass _FirstTestClass = null;


    public SecondTestClass()
    {

        _FirstTestClass = new FirstTestClass();
        _FirstTestClass.UpdateColor();



    }







}
