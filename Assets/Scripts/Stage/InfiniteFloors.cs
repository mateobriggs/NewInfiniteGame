using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteFloors : MonoBehaviour
{
    private Vector3 newFloorPosition;
    public List<GameObject> floorList = new List<GameObject>();
    public int positionInX;
    public int amountOfFloorBuilt;

    public void BuildNewFloor()
    {
        amountOfFloorBuilt++;
        for (float i = -4.5f; i < 2.2; i += 3.25f)
        {
            int listItem;
            listItem = Random.Range(0, 6);
            newFloorPosition = new Vector3(positionInX, i, 0);
            GameObject newFloor = Instantiate(floorList[listItem], newFloorPosition, Quaternion.identity);
        }
    }
}
