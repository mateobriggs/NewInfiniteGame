using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacter : MonoBehaviour
{
    public Image characterSprite;
    public Color selectedColor;
    private void Start()
    {
        characterSprite = GetComponentInChildren<Image>();
        selectedColor = characterSprite.color;
    }

    public void SelectColor()
    {
        FindObjectOfType<PlayerSelections>().characterColor = selectedColor;
        FindObjectOfType<TryColor>().tryingColor = selectedColor;
    }
}
