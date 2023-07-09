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
        public Image image;

        public powerUp(string power){
            this.power= power;
            
        }
        public powerUp(string power, Image image){
            this.power= power;
            this.image = image;
        }

    }


    powerUp[] powerUps = {
        new powerUp("rocket"),
        new powerUp("heavy"),
        new powerUp("slippery"),
        //new powerUp("water", Color.blue),
        new powerUp("rocks"),
        new powerUp("none"),
        new powerUp("none"),
        new powerUp("none"),
        new powerUp("none"),
        new powerUp("none"),

     };


    // Start is called before the first frame update
    void Start()
    {
        if (inital){
            nonePowerUp();
        }
        else{
            updatePowerUp();
        }
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
                    audioPowerUp.Play();
                    break;
                case ("heavy"):
                    collision.transform.parent.gameObject.GetComponent<BasicCar>().updateAcceleration(-2f);
                    audioPowerDown.Play();
                    break;
                case ("slippery"):
                    collision.transform.parent.gameObject.GetComponent<BasicCar>().updateAcceleration(-1.5f);
                    audioPowerDown.Play();
                    break;
                case ("rocks"):
                    collision.transform.parent.gameObject.GetComponent<BasicCar>().updateAcceleration(-2f);
                    audioPowerDown.Play();
                    break;
                default:
                    break;
            }
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

    public void nonePowerUp(){
        gameObject.SetActive(true);
        // Accede al color aleatorio utilizando el índice generado
        this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[5];
        //Color randomColor = powerUps[index].color;
        power = powerUps[5].power;

        // Accede al componente de material o color del objeto actual
    }

   
}
