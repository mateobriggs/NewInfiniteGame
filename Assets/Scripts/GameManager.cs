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
    void Start()
    {
        StartCoroutine("StartBuilding");
    }

    private void Update()
    {
        repeatBuildingTime = 2 / FindObjectOfType<AccelerateGame>().gameAcceleration;
        distanceTraveled += Time.deltaTime * FindObjectOfType<AccelerateGame>().gameAcceleration * 5;
        FindObjectOfType<GamePlayInformation>().UpdateDistance(distanceTraveled.ToString("f0"));    
    }
    public IEnumerator StartBuilding()
    {
        while (true)
        {
            FindObjectOfType<InfiniteFloors>().BuildNewFloor();
            yield return new WaitForSeconds(repeatBuildingTime);
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(1);
    }
}
