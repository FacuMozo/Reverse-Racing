using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BasicCar : MonoBehaviour
{
    private float acceleration = 3f;
    private float deacceleration = 1f;
    public GameObject gameManager;
    public bool isPlayer;

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
        if(transform.position.y < -6){
            if(acceleration<0){
                if(isPlayer){
                    gameManager.GetComponent<GameManager>().activateGameOver();
                }else{
                    gameManager.GetComponent<GameManager>().killPlayer();
                    Destroy(gameObject);
                }
            }
        }else{
            if(transform.position.y > 3.1){
                if(isPlayer){
                    gameManager.GetComponent<GameManager>().activateYouWin();
                }else{
                    gameManager.GetComponent<GameManager>().activateGameOver();
                }
            }
        }
    }

    public void updateAcceleration(float boost)
    {
        acceleration += boost;
    }
}
