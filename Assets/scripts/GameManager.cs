using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform player;
    private bool gameEnded = false;

    public void EndGame()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            Invoke("LoadEndScene", 2f);
        }
    }

    void LoadEndScene()
    {

        SaveScore.score = player.position.y.ToString("0");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
