using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BasicCar : MonoBehaviour
{
    private float acceleration = 3f;
    private float deacceleration = 1f;
    public GameObject gameManager;

    public ParticleSystem explosionParticle;

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
        if(transform.position.y < -5){
            if(acceleration<0){
                gameManager.GetComponent<GameManager>().killPlayer();
                Destroy(gameObject);
            }
        }
    }

    public void updateAcceleration(float boost)
    {
        acceleration += boost;
    }
}
