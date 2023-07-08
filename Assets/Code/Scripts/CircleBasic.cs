using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string power;
    public GameObject rocks;

    Vector3 speed = new Vector3(0.0f, -2.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + speed * Time.deltaTime;
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
