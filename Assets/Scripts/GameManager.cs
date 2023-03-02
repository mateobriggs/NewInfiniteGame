using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public float startBuildingTime;
    public float repeatBuildingTime;
    void Start()
    {
        //InvokeRepeating("StartBuilding", startBuildingTime, repeatBuildingTime);
        StartCoroutine("StartBuilding");
    }

    private void Update()
    {
        repeatBuildingTime = 2 / FindObjectOfType<AccelerateGame>().gameAcceleration;
    }
    public IEnumerator StartBuilding()
    {
        while (true)
        {
            FindObjectOfType<InfiniteFloors>().BuildNewFloor();
            yield return new WaitForSeconds(repeatBuildingTime);
        }
    }
}
