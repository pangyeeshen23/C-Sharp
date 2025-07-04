using TMPro;
using UnityEngine;
using UnityEngine.UI;

using UnityEditor.Advertisements;

public class GameManager : MonoBehaviour
{
    [Header("Score Elements")]
    public int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    [Header("GameOver")]
    public GameObject gameOverPanel;
    public TextMeshProUGUI gameOverPanelScoreText;
    public TextMeshProUGUI gameOverPanelHighScoreText;

    [Header("Sounds")]
    public AudioClip[] sliceSounds;
    private AudioSource audioSource;

    private int highScore;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        gameOverPanel.SetActive(false);
        highScore = PlayerPrefs.GetInt("HighScore");
        highScoreText.text = "Best: " + highScore.ToString();
    }

    public void IncreaseScore(int points)
    {
        score += points;
        if (score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = "Best: " + score.ToString();
        }
        scoreText.text = score.ToString();
    }

    public void PlaySlashAudio()
    {
        AudioClip randSounds = sliceSounds[Random.Range(0, sliceSounds.Length)];
        audioSource.PlayOneShot(randSounds);
    }

    public void OnBombHit()
    {
        Time.timeScale = 0;
        scoreText.text = "0";
        highScoreText.text = "Best: 0";
        gameOverPanelScoreText.text = "Score: " + score.ToString();
        highScore = PlayerPrefs.GetInt("HighScore");
        gameOverPanelHighScoreText.text = "High Score: " + highScore.ToString();
        gameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        score = 0;
        scoreText.text = "0";
        gameOverPanel.SetActive(false);
        gameOverPanelScoreText.text = "Score: 0";
        highScoreText.text = "Best: " + highScore.ToString();
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("Interactable"))
        {
            Destroy(g);
        }
        Time.timeScale = 1;
    }
}
