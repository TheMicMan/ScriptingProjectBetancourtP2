using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] strings = new string[3];

        string[0] = "First string";
        string[1] = "Second string";
        string[2] = "Third string";

        foreach (string item in strings)
        {
            print (item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
