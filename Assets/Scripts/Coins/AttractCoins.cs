using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractCoins : MonoBehaviour
{
    private GameObject target;
    private Vector3 dir;
    public float attractSpeed;

    private void Start()
    {
        target = GameObject.Find("Player");
    }
    void Update()
    {
        dir = (target.transform.position - transform.position).normalized;
        transform.position = transform.position + dir * Time.deltaTime * attractSpeed;
    }
}
