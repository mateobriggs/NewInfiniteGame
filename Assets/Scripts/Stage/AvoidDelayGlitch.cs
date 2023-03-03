using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidDelayGlitch : MonoBehaviour
{
    public bool shouldDelay = false;

    void Update()
    {
        if (!shouldDelay)
        {
            transform.position = new Vector3(0, transform.position.y, 0);
        }
    }
}
