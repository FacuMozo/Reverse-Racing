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
            if (Input.GetKeyDown(KeyCode.LeftArrow) )
            {
                switchRoadsleft();
                cooldown = .5f;
                if (slider != null)
                {
                    slider.value = 0;
                }
                // transform.Translate(new Vector3(-5,0,0));
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) )
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
                roads[i].transform.position = new Vector3 (roads[i-1].transform.position.x + 2, roads[i-1].transform.position.y,roads[i-1].transform.position.z) ;
                // roads[i].transform.Translate(new Vector3(-2f,0f,0f));
                StartCoroutine(moveroad(0.1f,roads[i], new Vector3(-0.5f,0,0)));
                StartCoroutine(moveroad(0.2f,roads[i], new Vector3(-0.5f,0,0)));
                StartCoroutine(moveroad(0.3f,roads[i], new Vector3(-0.5f,0,0)));
                StartCoroutine(moveroad(0.4f,roads[i], new Vector3(-0.5f,0,0)));
            }else{
                roads[i].transform.position = new Vector3(finalPosition.x + 2, finalPosition.y,finalPosition.z) ;
                StartCoroutine(moveroad(0.1f,roads[i], new Vector3(-0.5f,0,0)));
                StartCoroutine(moveroad(0.2f,roads[i], new Vector3(-0.5f,0,0)));
                StartCoroutine(moveroad(0.3f,roads[i], new Vector3(-0.5f,0,0)));
                StartCoroutine(moveroad(0.4f,roads[i], new Vector3(-0.5f,0,0)));
                
            }
        }
    }
    void switchRoadsright(){
        Vector3 initialPosition = roads[0].transform.position;
        for (int i = 0; i  < roads.Length; i++)
        {
            if (i != roads.Length-1){
                // roads[i].transform.position = roads[i+1].transform.position;
                roads[i].transform.position = new Vector3 (roads[i+1].transform.position.x - 2, roads[i+1].transform.position.y,roads[i+1].transform.position.z) ;
                StartCoroutine(moveroad(0.1f,roads[i], new Vector3(0.5f,0,0)));
                StartCoroutine(moveroad(0.2f,roads[i], new Vector3(0.5f,0,0)));
                StartCoroutine(moveroad(0.3f,roads[i], new Vector3(0.5f,0,0)));
                StartCoroutine(moveroad(0.4f,roads[i], new Vector3(0.5f,0,0)));
            }else{
                // roads[i].transform.position = initialPosition;
                roads[i].transform.position = new Vector3(initialPosition.x - 2, initialPosition.y,initialPosition.z) ;
                StartCoroutine(moveroad(0.1f,roads[i], new Vector3(0.5f,0,0)));
                StartCoroutine(moveroad(0.2f,roads[i], new Vector3(0.5f,0,0)));
                StartCoroutine(moveroad(0.3f,roads[i], new Vector3(0.5f,0,0)));
                StartCoroutine(moveroad(0.4f,roads[i], new Vector3(0.5f,0,0)));
            }
        }
    }

    IEnumerator  moveroad(float delayTime, GameObject road, Vector3 move){
        yield return new WaitForSeconds(delayTime);

        road.transform.Translate(move) ;
    }


}
