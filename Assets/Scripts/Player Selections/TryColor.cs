using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TryColor : MonoBehaviour
{
    public Color tryingColor = Color.black;


    private void Update()
    {
        GetComponent<Image>().color = tryingColor;
    }
}
