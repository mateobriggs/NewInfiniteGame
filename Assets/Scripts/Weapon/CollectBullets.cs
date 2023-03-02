using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBullets : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            int bullets = FindObjectOfType<PowerManager>().bullets += 1;
            FindObjectOfType<GamePlayInformation>().UpdateBullets(bullets.ToString());  
            collision.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }
}
