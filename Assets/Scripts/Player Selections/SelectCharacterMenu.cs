using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCharacterMenu : MonoBehaviour
{
    public void GoToMenu()
    {
            SceneManager.LoadScene("Main Menu");
    }

    public void SaveChanges()
    {
        PlayerSelections playerSelections = FindObjectOfType<PlayerSelections>();
        playerSelections.youSelectAColor = true;
        playerSelections.SaveChosenColor();
    }
}
