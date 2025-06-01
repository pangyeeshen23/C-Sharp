using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    private int player1Score = 0;
    private int player2Score = 0;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;

    public int goalToWin;

    // Update is called once per frame
    void Update()
    {
        if(this.player1Score >= this.goalToWin || this.player2Score >= this.goalToWin)
        {
            Debug.Log("Game Over");
        }
    }

    private void FixedUpdate()
    {
        TextMeshProUGUI uiScorePlayer1 = this.scoreTextPlayer1.GetComponent<TextMeshProUGUI>();
        uiScorePlayer1.text = this.player1Score.ToString();
        TextMeshProUGUI uiScorePlayer2 = this.scoreTextPlayer2.GetComponent<TextMeshProUGUI>();
        uiScorePlayer2.text = this.player2Score.ToString();
    }

    public void IncreaseScore(string playerName)
    {
        if (playerName == "Player1") player1Score++;
        else if (playerName == "Player2") player2Score++;
    }
}
