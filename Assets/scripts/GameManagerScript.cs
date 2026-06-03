using UnityEngine;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}