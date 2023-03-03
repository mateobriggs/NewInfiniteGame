using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGhostFollowPlayer : MonoBehaviour
{
    public Transform target;
    void Update()
    {
        transform.position = new Vector3(0, target.position.y, 1);
    }
}
