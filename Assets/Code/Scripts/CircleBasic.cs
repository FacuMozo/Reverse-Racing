using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;


public class CircleBasic : MonoBehaviour
{
    public string power;

    public GameObject rocks;
    
    public bool inital = false;

    public Sprite[] sprites;

    public AudioSource audioPowerUp;
    public AudioSource audioPowerDown;

    public class powerUp{
        public string power;
        public Color color;
        public Image image;

        public powerUp(string power, Color color){
            this.power= power;
            this.color = color;
            
        }
        public powerUp(string power, Color color, Image image){
            this.power= power;
            this.color = color;
            this.image = image;
        }

    }


    powerUp[] powerUps = {
        new powerUp("rocket", Color.red),
        new powerUp("heavy", Color.yellow),
        new powerUp("slippery", Color.green),
        //new powerUp("water", Color.blue),
        new powerUp("rocks", Color.gray)
     };


    // Start is called before the first frame update
    void Start()
    {
        updatePowerUp();
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = transform.position + speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Player")
        {
            switch (power)
            {
                case ("rocket"):
                    collision.transform.parent.gameObject.GetComponent<BasicCar>().updateAcceleration(2f);
                    break;
                case ("heavy"):
                    collision.transform.parent.gameObject.GetComponent<BasicCar>().updateAcceleration(-2f);
                    break;
                case ("slippery"):
                    collision.transform.parent.gameObject.GetComponent<BasicCar>().updateAcceleration(-1f);
                    break;
                case ("water"):
                    collision.transform.parent.gameObject.GetComponent<BasicCar>().updateAcceleration(-1f);
                    break;
                case ("rocks"):
                    collision.transform.parent.gameObject.GetComponent<BasicCar>().updateAcceleration(-2f);
                    break;
                default:
                    break;
            }
            audioPowerUp.Play();
            gameObject.SetActive(false);
        }
    }

    public void updatePowerUp(){
        int index= Random.Range(0,powerUps.Length);
        gameObject.SetActive(true);
        // Accede al color aleatorio utilizando el índice generado
        this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[index];
        //Color randomColor = powerUps[index].color;
        power = powerUps[index].power;

        // Accede al componente de material o color del objeto actual
    }

    public void updatePowerUp(string powerUp){
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
}
