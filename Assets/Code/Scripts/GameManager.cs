using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject youWinCanvas;
    int cantPlayers = 5;
    public string sceneToLoad;
    public string sceneToBack;

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

    public void killPlayer(){
        cantPlayers -= 1;
        if(cantPlayers == 1){
            activateYouWin();
        }
    }

    public void startGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void exitGame()
    {
        SceneManager.LoadScene(sceneToBack);
    }
}
