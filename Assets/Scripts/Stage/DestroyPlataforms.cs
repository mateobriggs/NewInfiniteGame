using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlataforms : MonoBehaviour
{
    private void Update()
    {
        if(transform.position.x < -30) Destroy(gameObject);
    }
}
