using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public bool gameRestarted = false;
    public void Restart()
    {
        SceneManager.LoadScene(0);
        RestartStatistics();
    }

    public void RestartStatistics()
    {
        Destroy(FindObjectOfType<GamePlayInformation>().gameObject);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
