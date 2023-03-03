using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GamePlayInformation : MonoBehaviour
{
    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI bulletsText;
    public TextMeshProUGUI distanceTraveledText;
    public int brokenWalls;
    public bool doubleScore = false;

    public static GamePlayInformation gamePlayInformation;
    private void Awake()
    {


        if (gamePlayInformation == null)
        {
            gamePlayInformation = this;
        }
        else if (gamePlayInformation != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
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
        distanceTraveledText.text = text;
    }

    public void UpdateBrokenWalls()
    {
        brokenWalls++;
    }

    public void DoubleScore()
    {
        doubleScore = true;
    }

    private void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            coinsText.gameObject.SetActive(false);
            livesText.gameObject.SetActive(false);
            distanceTraveledText.gameObject.SetActive(false);
            bulletsText.gameObject.SetActive(false);
        }
    }
}
