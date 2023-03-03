using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    private bool coinAlreadyCollected = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" && !coinAlreadyCollected) 
        {
            gameObject.SetActive(false);
            FindObjectOfType<CoinsManager>().AddCoins();
            coinAlreadyCollected = true;
        }
        else if(collision.gameObject.name == "Magnet")
        {   
            gameObject.GetComponent<AttractCoins>().enabled = true;
        }
    }
}
