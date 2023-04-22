using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public TMPro.TextMeshProUGUI scoreText;
    private int scoreNum = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player")) 
            collision.gameObject.SetActive(false);
        scoreNum++;
        scoreText.text = scoreNum.ToString();
    }
}
