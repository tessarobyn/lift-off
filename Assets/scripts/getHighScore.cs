using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class getHighScore : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;

    void Start()
    {
        if (PlayerPrefs.HasKey("highScore"))
        {
            
        }
        else
        {
            PlayerPrefs.SetString("highScore", "0");
            PlayerPrefs.Save();
        }
        highScoreText.text += PlayerPrefs.GetString("highScore") + "m";

    }
}
