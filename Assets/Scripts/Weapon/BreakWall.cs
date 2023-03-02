using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWall : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Wall")
        {
            collision.gameObject.SetActive(false);  
            gameObject.SetActive(false);
            FindObjectOfType<GamePlayInformation>().UpdateBrokenWalls();
        }
    }
}
