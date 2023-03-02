using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    private int lives = 8;
    public TextMeshProUGUI livesText;
    public void TakeLives()
    {
        lives--;
        livesText.text = lives.ToString();
    }

    public void AddLives()
    {
        lives++;
        livesText.text = lives.ToString();
    }
}
