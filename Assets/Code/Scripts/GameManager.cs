using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject youWinCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activateGameOver()
    {
        gameOverCanvas.SetActive(true);
    }

    public void activateYouWin()
    {
        youWinCanvas.SetActive(true);
    }
}
