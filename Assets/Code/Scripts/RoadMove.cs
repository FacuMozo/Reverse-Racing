using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoadMove : MonoBehaviour
{

    public GameObject[] roads;

    private bool gameOver= false;

    public float cooldown = 0f;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        if (slider != null)
        {
            slider.value = 60;
        }
    } 

    // Update is called once per frame
    void Update()
    {
        if (cooldown <= 0f)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && !gameOver)
            {
                switchRoadsleft();
                cooldown = .5f;
                if (slider != null)
                {
                    slider.value = 0;
                }
                // transform.Translate(new Vector3(-5,0,0));
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && !gameOver)
            {
                switchRoadsright();
                cooldown = .5f;
                if (slider != null)
                {
                    slider.value = 0;
                }
                // transform.Translate(new Vector3(5,0,0));
            }
        }

        if (cooldown > 0f)
        {
            cooldown -= Time.deltaTime;
            if (slider != null)
            {
                slider.value++;
            }
        }
       
    }

    void switchRoadsleft(){
        Vector3 finalPosition = roads[roads.Length-1].transform.position;
        for (int i = roads.Length-1; i > -1; i--)
        {
            if (i > 0){
                roads[i].transform.position = roads[i-1].transform.position;
            }else{
                roads[i].transform.position = finalPosition;
            }
        }
    }
    void switchRoadsright(){
        Vector3 initialPosition = roads[0].transform.position;
        for (int i = 0; i  < roads.Length; i++)
        {
            if (i != roads.Length-1){
                roads[i].transform.position = roads[i+1].transform.position;
            }else{
                roads[i].transform.position = initialPosition;
            }
        }
    }


}
