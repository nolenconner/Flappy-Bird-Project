using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 


public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject overScreen;


    [ContextMenu("Increase Score")]
    public void addScore(){
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame(){ //game resets to beginning sceen when button is clicked
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){ //shows game over screen
        overScreen.SetActive(true);
    }
}
