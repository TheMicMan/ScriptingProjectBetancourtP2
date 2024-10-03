using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesaNDFunction : MonoBehaviour
{
    // Create a variable of type int
    int MyInt = 11;
    // Start is called before the first frame update
    void Start()
    {
        MyInt = MuliplyByTwo(MyInt);
    Debug.Log(MyInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    int MuliplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}