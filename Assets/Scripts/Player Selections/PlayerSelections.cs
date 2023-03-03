using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelections : MonoBehaviour
{
    public Color characterColor;
    private PlayerSelections playerSelections;

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
        //print(playerSelections.characterColor);
    }

    public Color SaveChosenColor()
    {
        print(characterColor);
        return characterColor;
    }
}
