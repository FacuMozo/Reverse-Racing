using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    public string power;

    Vector3 speed = new Vector3(0.0f, -2.0f, 0.0f);

    public bool inital = false;

    Color[] colors = {Color.green,Color.red, Color.white, Color.blue, Color.yellow, Color.black}; 
    string[] powerUps = {"rocket","heavy","slippery","water","rocks","dust" };

    // Start is called before the first frame update
    void Start()
    {
        int index= Random.Range(0,colors.Length);
        int moneda= Random.Range(0,2);
       
        
        // Accede al color aleatorio utilizando el índice generado
        Color randomColor = colors[index];

        // Accede al componente de material o color del objeto actual
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            // Aplica el color aleatorio al material del objeto
            renderer.material.color = randomColor;
        }
        else
        {
            // Si no hay un componente Renderer, intenta acceder al componente de color
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                // Aplica el color aleatorio al componente de color del objeto (sprite)
                spriteRenderer.color = randomColor;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = transform.position + speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switch (power)
            {
                case ("rocket"):
                    break;
                case ("heavy"):
                    break;
                case ("slippery"):
                    break;
                case ("water"):
                    break;
                case ("rocks"):
                    break;
                case ("dust"):
                    break;
                default:
                    break;
            }
            Destroy(gameObject);
        }
    }
}
