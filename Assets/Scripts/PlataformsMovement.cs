using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformsMovement : MonoBehaviour
{
    private float speed = 4;

    void Update()
    {
        transform.position = transform.position + Vector3.left * Time.deltaTime * speed * FindObjectOfType<AccelerateGame>().gameAcceleration;
    }
}
