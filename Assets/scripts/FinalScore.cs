using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Start()
    {
        scoreText.text = SaveScore.score;
        if (int.Parse(PlayerPrefs.GetString("highScore")) < int.Parse(SaveScore.score)) {
            PlayerPrefs.SetString("highScore", SaveScore.score);
            PlayerPrefs.Save();
        }
    }
}