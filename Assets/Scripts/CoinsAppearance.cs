using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsAppearance: MonoBehaviour
{
    void Start()
    {
        int coinProbability = Random.Range(0, 100);
        if(coinProbability > 85f)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (coinProbability > 50f)
        {
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
