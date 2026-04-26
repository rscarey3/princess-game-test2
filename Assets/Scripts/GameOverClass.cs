using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverClass : MonoBehaviour
{
    public void MainFromGameOver()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene("TestScene4");
    }
}
