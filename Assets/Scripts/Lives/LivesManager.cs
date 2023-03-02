using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    private int lives = 3;
    public void TakeLives()
    {
        lives--;
        FindObjectOfType<GamePlayInformation>().UpdateLives(lives.ToString());
        if(lives == 0)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    public void AddLives()
    {
        lives++;
        FindObjectOfType<GamePlayInformation>().UpdateLives(lives.ToString());
    }
}
