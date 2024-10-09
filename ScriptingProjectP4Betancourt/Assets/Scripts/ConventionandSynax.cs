using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionandSynax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        //I want the x position of my game object to appear on the console
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        //I want to know my y position is at all times
        //Debug.Log(tranform.position.y);

        //I want my console to say something if my object is below 5
        if (transform.position.y <= 5f)
            Debug.Log("I am about to hit the ground");


    }
}
