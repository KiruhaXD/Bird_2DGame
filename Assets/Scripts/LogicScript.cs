using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // добавляем библиотеку для Text
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // тут мы создаем подсчет очков, когда птичка проходит через балки
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) 
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() 
    {
        gameOverScreen.SetActive(true);
    }
}
