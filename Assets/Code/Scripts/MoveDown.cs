using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed;
    private float downBound = -10;

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
            transform.position = new Vector3(transform.position.x, 9f,0f);
            if (CircleBasic != null)
            {
                CircleBasic.GetComponent<CircleBasic>().updatePowerUp();
            }
        }
    }


}
