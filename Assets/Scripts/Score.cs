using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int scoreToWin = 5;
    public GameObject gameOverPanel;
    public TMPro.TextMeshProUGUI scoreText;
    private int scoreNum = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player")) 
            collision.gameObject.SetActive(false);
        scoreNum++;
        scoreText.text = scoreNum.ToString();
        CheckForGameOver();
    }

    private void CheckForGameOver()
    {
        if (scoreNum == scoreToWin)
            gameOverPanel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
