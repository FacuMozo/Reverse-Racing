using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parpadeo : MonoBehaviour
{
    int parpadeos = 7;
    float resetTime = 0.6f;
    float tiempoRestante;
    public GameObject sprite;
    // Start is called before the first frame update
    void Start()
    {
        tiempoRestante = resetTime;
    }

    // Update is called once per frame
    void Update()
    {
        tiempoRestante -= Time.deltaTime;
        if(tiempoRestante<=0f){
            sprite.GetComponent<SpriteRenderer>().enabled = !sprite.GetComponent<SpriteRenderer>().enabled;
            if(parpadeos > 0){
                parpadeos--;
                tiempoRestante = resetTime;
            }else{
                Destroy(gameObject);
            }
        }
    }
}
