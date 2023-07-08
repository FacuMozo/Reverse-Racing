using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCar : MonoBehaviour
{
    private float health = 5;
    private float acceleration = 0f;
    private float deacceleration = 0.00005f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(acceleration != 0)
        {
            transform.position = transform.position + new Vector3(0,acceleration);
            acceleration -= deacceleration;
            if (acceleration < deacceleration && acceleration > -deacceleration)
            {
                acceleration = 0f;
            }
        }
    }

    public void updateAcceleration(float boost)
    {
        acceleration += boost;
    }
}
