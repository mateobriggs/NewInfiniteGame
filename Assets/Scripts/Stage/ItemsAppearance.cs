using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsAppearance : MonoBehaviour
{
    void Start()
    {
        int amountOfFloorBuilt = FindObjectOfType<InfiniteFloors>().amountOfFloorBuilt;
        int coinProbability = Random.Range(0, 100);
        bool X2AlreadyCollected = FindObjectOfType<GamePlayInformation>().doubleScore;

        if (coinProbability > 39f)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (coinProbability > 29f)
        {
            if(amountOfFloorBuilt % 5 == 0)
                gameObject.transform.GetChild(1).gameObject.SetActive(true);
            else if(amountOfFloorBuilt % 10 == 0) if (!X2AlreadyCollected) gameObject.transform.GetChild(5).gameObject.SetActive(true);
        }
        else if (coinProbability > 19f)
        {
            //if (amountOfFloorBuilt % 5 == 0)
                gameObject.transform.GetChild(2).gameObject.SetActive(true);
        }
        else if (coinProbability > 9f)
        {
            //if (amountOfFloorBuilt % 5 == 0)
                gameObject.transform.GetChild(3).gameObject.SetActive(true);
        }
        else if (coinProbability > 0f)
        {
            //if (amountOfFloorBuilt % 5 == 0)
                gameObject.transform.GetChild(4).gameObject.SetActive(true);
        }
    }
}
