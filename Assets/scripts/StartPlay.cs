using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartPlay : MonoBehaviour
{
    private Button button;

    void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(startPlay);
    }

    void startPlay()
    {
        SceneManager.LoadScene(1);
    }
}
