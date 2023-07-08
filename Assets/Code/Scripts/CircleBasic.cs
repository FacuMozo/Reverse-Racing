using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    public string power;

    public GameObject rocks;
    
    public bool inital = false;

    public class powerUp{
        public string power;
        public Color color;

        public powerUp(string power, Color color){
            this.power= power;
            this.color = color;
        }

    }


    powerUp[] powerUps = {
        new powerUp("rocket", Color.red), 
        new powerUp("heavy", Color.yellow), 
        new powerUp("slippery", Color.green), 
        new powerUp("water", Color.blue), 
        new powerUp("rocks", Color.gray), 
        new powerUp("dust", Color.black) 
     };


    // Start is called before the first frame update
    void Start()
    {
        int index= Random.Range(0,powerUps.Length);
        
        // Accede al color aleatorio utilizando el índice generado
        Color randomColor = powerUps[index].color;
        power = powerUps[index].power;

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
                    Instantiate(rocks,new Vector3(0,5.392388f, 0), transform.rotation);
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
