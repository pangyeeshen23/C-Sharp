using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Score Elements")]
    public int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    [Header("GameOver")]
    public GameObject gameOverPanel;
    public TextMeshProUGUI gameOverPanelScoreText;

    private void Awake()
    {
        gameOverPanel.SetActive(false);
    }

    public void IncreaseScore(int points)
    {
        score += points;
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        if (score > highScore) PlayerPrefs.SetInt("HighScore", score);
        scoreText.text = score.ToString();
        highScoreText.text = "Best: " + score.ToString();
    }

    public void OnBombHit()
    {
        Time.timeScale = 0;
        gameOverPanelScoreText.text = "Score: " + score.ToString();
        gameOverPanel.SetActive(true);
        Debug.Log("Bomb Hit");
    }
}
