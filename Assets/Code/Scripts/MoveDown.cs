using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed;
    private float downBound = -9.95f;
    private float speedTimerIncrease = 35f;

    public GameObject CircleBasic;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Alternativa para gameover
        //if ( unit3_PlayerController.gameOver == false)
        transform.Translate(Vector3.down * Time.deltaTime * speed);

        if ( transform.position.y < downBound){
            transform.position = new Vector3(transform.position.x, 37f,0f);
            if (CircleBasic != null)
            {
                CircleBasic.GetComponent<CircleBasic>().updatePowerUp();
            }
        }

        if (speedTimerIncrease <= 0f){
            speed+= 0.2f;
            speedTimerIncrease = 6f;
        }else{
            speedTimerIncrease-= Time.deltaTime;
        }
        
    }


}
