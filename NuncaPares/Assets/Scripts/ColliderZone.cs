using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderZone : MonoBehaviour
{
    public float penaltyValue = 2.5f;
    
    public float batteryPercentage = 70.0f;

    float lowBattery;

    // Start is called before the first frame update
    void Start()
    {
        lowBattery = (batteryPercentage / 2) + penaltyValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(batteryPercentage >= lowBattery)
        {
            batteryPercentage -= penaltyValue;
            Debug.Log(batteryPercentage);
        }

        
    }
}
