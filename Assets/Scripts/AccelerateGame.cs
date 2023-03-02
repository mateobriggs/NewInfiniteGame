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
        gameAcceleration += Time.deltaTime * 0.01f;
    }
}
