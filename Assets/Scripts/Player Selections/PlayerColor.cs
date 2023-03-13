using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    public PlayerSelections playerSelections;
    void Start()
    {
        playerSelections = FindObjectOfType<PlayerSelections>();
        if (playerSelections.youSelectAColor)
        {
            Color playerColor = playerSelections.SaveChosenColor();
            GetComponent<SpriteRenderer>().color = playerColor;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.black;
        }
    }
}
