using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMove : MonoBehaviour
{

    public GameObject[] roads;

    private bool gameOver= false;

    // Start is called before the first frame update
    void Start()
    {
         
    } 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && !gameOver)
        {
            switchRoadsleft();
            // transform.Translate(new Vector3(-5,0,0));
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && !gameOver)
        {
            switchRoadsright();
            // transform.Translate(new Vector3(5,0,0));
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
