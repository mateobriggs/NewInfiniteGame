using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMagnet : MonoBehaviour
{
    public float timeToDeactivate;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            
            collision.gameObject.transform.GetChild(1).gameObject.SetActive(true);
            collision.gameObject.transform.GetChild(2).gameObject.SetActive(true);
            StartCoroutine(DeactivateMagnet(collision.gameObject));
        }
    }

    public IEnumerator DeactivateMagnet(GameObject player)
    {
        yield return new WaitForSeconds(timeToDeactivate);
        player.transform.GetChild(1).gameObject.SetActive(false);
        player.transform.GetChild(2).gameObject.SetActive(false);
        print("magnet desactivado");
    }
}
