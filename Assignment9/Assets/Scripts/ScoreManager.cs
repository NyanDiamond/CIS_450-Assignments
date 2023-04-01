using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    int score = 0;
    [SerializeField] TextMeshProUGUI counter;
    // Start is called before the first frame update
    void Start()
    {
        counter.text = "Score: " + score;
    }

    public void AddScore()
    {
        score++;
        counter.text = "Score: " + score;
    }

    public void MinusScore()
    {
        score--;
        if (score < 0) score = 0;
        counter.text = "Score: " + score;
    }
}
