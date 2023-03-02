using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GamePlayInformation : MonoBehaviour
{
    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI bulletsText;
    public TextMeshProUGUI distanceTraveledText;
    
    public void UpdateCoins(string text)
    {
        coinsText.text = text;
    }

    public void UpdateLives(string text)
    {
        livesText.text = text;
    }

    public void UpdateBullets(string text)
    {
        bulletsText.text = text;
    }

    public void UpdateDistance(string text)
    {
        distanceTraveledText.text = text + " m";
    }
}
