using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" || collision.gameObject.name == "Magnet")
        {
            gameObject.SetActive(false);
            FindObjectOfType<CoinsManager>().AddCoins();
        }
    }
}
