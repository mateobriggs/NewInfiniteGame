using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            FindObjectOfType<GamePlayInformation>().DoubleScore();
            gameObject.SetActive(false);
        }
    }
}
