using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatement : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float ColdLimitTemperature = 40.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime;
    }


    void TemperatureTest()
    {
        // If the coffee's temperature is greater than the hottest
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold");
        }
        // If it is neither of those then...
        else
        {

            // ... do this.
            print("Coffee is just right");
        }
    }
}