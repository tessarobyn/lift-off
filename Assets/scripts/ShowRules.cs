using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowRules : MonoBehaviour
{
    private Button button;

    void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(showRules);
    }

    void showRules()
    {
        SceneManager.LoadScene(3);
    }
}
