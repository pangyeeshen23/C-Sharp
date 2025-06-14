using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameStarted;
    public int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    private void Awake()
    {
        highScoreText.text =  "Best: " + GetHighScore().ToString();
    }

    public void StartGame()
    {
        gameStarted = true;
        FindFirstObjectByType<Road>().StartBuilding();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace)) StartGame();
    }

    public void EndGame()
    {
        SceneManager.LoadScene(0);
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        if(score > GetHighScore())
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = "Best: " + score.ToString();
        }
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt("HighScore");
    }
}
