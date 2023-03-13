using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelections : MonoBehaviour
{
    public Color characterColor;
    private PlayerSelections playerSelections;
    public bool youSelectAColor = false;

    private void Awake()
    {
        if(playerSelections == null)
        {
            playerSelections = this;
        }
        else if(playerSelections != this)
        {
            Destroy(playerSelections);
        }

        DontDestroyOnLoad(gameObject);
    }

    public Color SaveChosenColor()
    {
        return characterColor;
    }
}
