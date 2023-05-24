using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    private bool isFirstClick = true;
    [SerializeField] private GameObject GameObject;
    private int score=0;
    [SerializeField] private TMP_Text scoreText;
    void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) && isFirstClick)
        {
            Destroy(gameObject);
            isFirstClick = false;
        }
    }

    public void updateScore(int newScore)
    {
        score += newScore;
        scoreText.text = "Score: " + score.ToString();
    }
}
