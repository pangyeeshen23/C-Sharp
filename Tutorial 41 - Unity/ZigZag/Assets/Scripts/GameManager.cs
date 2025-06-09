using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameStarted;

    public void StartGame()
    {
        gameStarted = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace)) StartGame();
    }

    public void EndGame()
    {
        SceneManager.LoadScene(0);
    }
}
