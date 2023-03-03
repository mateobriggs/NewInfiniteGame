using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public float startBuildingTime;
    public float repeatBuildingTime;
    private float distanceTraveled;
    private InfiniteFloors infiniteFloors;
    private AccelerateGame accelerateGame;
    private GamePlayInformation gamePlayInformation;
    void Start()
    {
        infiniteFloors = FindObjectOfType<InfiniteFloors>();
        accelerateGame = FindObjectOfType<AccelerateGame>();
        gamePlayInformation = FindObjectOfType<GamePlayInformation>();
        StartCoroutine("StartBuilding");
    }

    private void Update()
    {
        repeatBuildingTime = 2 / accelerateGame.gameAcceleration;
        distanceTraveled += Time.deltaTime * accelerateGame.gameAcceleration * 5;
        gamePlayInformation.UpdateDistance(distanceTraveled.ToString("f0"));    
    }
    public IEnumerator StartBuilding()
    {
        while (true)
        {
            infiniteFloors.BuildNewFloor();
            yield return new WaitForSeconds(repeatBuildingTime);
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(1);
    }
}
