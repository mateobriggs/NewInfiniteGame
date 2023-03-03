using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateReturnWeapon : MonoBehaviour
{
    public GameObject playerGhost;

    private void Start()
    {
        playerGhost = GameObject.Find("PlayerGhost");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            FindObjectOfType<ReturnToInitPos>().returnPosibilities++;
            playerGhost.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.SetActive(false);    
        }
    }
}
