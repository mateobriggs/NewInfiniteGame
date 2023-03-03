using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    void Start()
    {
        Color playerColor = FindObjectOfType<PlayerSelections>().SaveChosenColor();
        GetComponent<SpriteRenderer>().color = playerColor;
    }
}
