using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverInformation : MonoBehaviour
{
    public string totalDistance;
    public string totalCoins;
    public int totalScore;
    private int totalBrokenWalls;

    public List<TextMeshProUGUI> texts;
    public Button restartButton;

    /*public TextMeshProUGUI totalDistanceText;
    public TextMeshProUGUI totalCoinsText;
    public TextMeshProUGUI totalScoreText;*/
    
    
    void Start()
    {
        totalCoins = FindObjectOfType<GamePlayInformation>().coinsText.text;
        totalDistance = FindObjectOfType<GamePlayInformation>().distanceTraveledText.text;
        totalBrokenWalls = FindObjectOfType<GamePlayInformation>().brokenWalls;

        //texts[0].text = "You collected " + totalCoins + " coins";
       // texts[1].text = "You ran " + totalDistance + " meters";
        int coinsValue = int.Parse(totalCoins);
        int distanceValue = int.Parse(totalDistance);

        totalScore = coinsValue * 20 + + totalBrokenWalls * 40 + distanceValue;
        //texts[2].text = "Your Score was " + totalScore.ToString();
        StartCoroutine(ShowInfo());
    }

    public IEnumerator ShowInfo()
    {
        foreach(TextMeshProUGUI text in texts)
        {
            yield return new WaitForSeconds(1);
            if(texts.IndexOf(text) == 0)
            {
                text.text = "You collected " + totalCoins + " coins";
            }
            else if(texts.IndexOf(text) == 1)
            {
                text.text = "You ran " + totalDistance + " meters";
            }
            else if (texts.IndexOf(text) == 2)
            {
                text.text = "Your Score was " + totalScore.ToString();
            }
        }

        restartButton.gameObject.SetActive(true);
    }
}
