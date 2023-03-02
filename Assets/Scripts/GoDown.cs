using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDown : MonoBehaviour
{
    public float radius;
    public LayerMask floorMask;
    public float offset;
    public void ClimbDownAFloor()
    {
        if (transform.position.y > -0.85)
        {
            if (Physics2D.OverlapCircle(transform.position + Vector3.down * offset, radius, floorMask))
            {
                Vector3 position = transform.position;
                float distanceToClimb = 3.10f;
                transform.position = position - new Vector3(0, distanceToClimb, 0);
            }
        }
        else return;
    }
}
