using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeLives : MonoBehaviour
{
    private bool alreadyDamaged = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !alreadyDamaged)
        {
            FindObjectOfType<LivesManager>().TakeLives();
            alreadyDamaged = true;  
        }
    }
}
