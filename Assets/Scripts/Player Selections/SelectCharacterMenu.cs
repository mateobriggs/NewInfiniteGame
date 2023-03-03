using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCharacterMenu : MonoBehaviour
{
    //private bool changesSaved = false;
    public void GoToMenu()
    {
        //if(changesSaved)
            SceneManager.LoadScene("Main Menu");
        /*else if(!changesSaved)
        {
            FindObjectOfType<PlayerSelections>().characterColor = Color.white;
            SceneManager.LoadScene("Main Menu");
        }*/
        
    }

    /*public void SaveChanges()
    {
        FindObjectOfType<PlayerSelections>().SaveChosenColor();
        changesSaved = true;
    }*/
}
