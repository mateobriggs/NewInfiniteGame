using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateGame : MonoBehaviour
{
    public float gameAcceleration;

    private void Start()
    {
        gameAcceleration = 1;
    }

    void Update()
    {
        if (gameAcceleration < 2)
        {
            gameAcceleration += Time.deltaTime * 0.01f;
        }
        else gameAcceleration = 2;
    }
}
