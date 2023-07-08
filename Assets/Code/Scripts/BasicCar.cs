using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BasicCar : MonoBehaviour
{
    private float acceleration = 0f;
    private float deacceleration = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(acceleration != 0)
        {
            transform.position = transform.position + new Vector3(0,acceleration) * Time.deltaTime;
            acceleration -= Math.Sign(acceleration) * deacceleration * Time.deltaTime;
            if (acceleration < deacceleration && acceleration > -deacceleration)
            {
                acceleration = 0f;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            acceleration += 1;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                acceleration -= 1;
            }
        }
    }

    public void updateAcceleration(float boost)
    {
        acceleration += boost;
    }
}
