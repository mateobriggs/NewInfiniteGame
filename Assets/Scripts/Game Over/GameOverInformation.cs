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
    private bool doubleScore;

    public List<TextMeshProUGUI> texts;
    public Button restartButton;
    
    
    void Start()
    {
        GamePlayInformation gamePlayInformation = FindObjectOfType<GamePlayInformation>();
        totalCoins = gamePlayInformation.coinsText.text;
        totalDistance = gamePlayInformation.distanceTraveledText.text;
        totalBrokenWalls = gamePlayInformation.brokenWalls;
        doubleScore = gamePlayInformation.doubleScore;

        int coinsValue = int.Parse(totalCoins);
        int distanceValue = int.Parse(totalDistance);
        if (doubleScore) totalScore = (coinsValue * 20 + +totalBrokenWalls * 40 + distanceValue) * 2;
        else totalScore = coinsValue * 20 + +totalBrokenWalls * 40 + distanceValue;
        print(doubleScore);
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
