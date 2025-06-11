using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;
    public string scoreKey = "PlayerScore";
    public int savedScore = 0;

    public void OnClick()
    {
        score++;
        if (score >= 10)
        {
            score += 2; 
        }
        if (score >= 20)
        {
            score += 3;
        }
        if (score >= 30)
        {
            score += 4;
        }
        if (score >= 40)
        {
            score += 5;
        }
    }

    public void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void Save()
    {
        PlayerPrefs.SetInt(scoreKey, score);
    }

    public void Load()
    {
        score = PlayerPrefs.GetInt(scoreKey, 0);
        scoreText.text = "Score: " + score.ToString();
    }

    private void Start()
    {
        Debug.Log("This is a Game where you have to Click a button to raise your score than you can save that score and load it whenever at every time");
    }
}
