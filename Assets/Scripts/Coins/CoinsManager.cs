using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    private int collectedCoins;
    public void AddCoins()
    {
        collectedCoins++;
        FindObjectOfType<GamePlayInformation>().UpdateCoins(collectedCoins.ToString());
    }
}
