using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinsManager : MonoBehaviour
{
    private int collectedCoins;
    public TextMeshProUGUI coinsText;
    public void AddCoins()
    {
        collectedCoins++;
        coinsText.text = collectedCoins.ToString(); 
    }
}
