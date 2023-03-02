using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsAppearance : MonoBehaviour
{
    void Start()
    {
        int coinProbability = Random.Range(0, 100);
        if (coinProbability > 50f)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (coinProbability > 43f)
        {
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (coinProbability > 25f)
        {
            gameObject.transform.GetChild(2).gameObject.SetActive(true);
        }
        else if (coinProbability > 10f)
        {
            gameObject.transform.GetChild(3).gameObject.SetActive(true);
        }
    }
}
