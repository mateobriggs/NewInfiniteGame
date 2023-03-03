using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidWallGlitch : MonoBehaviour
{
    public float radius;
    public LayerMask wallMask;
    public float offset;
    public PlataformsMovement plataformsMovements;
    public AvoidDelayGlitch avoidDelayGlitch;

    private void Start()
    {
        avoidDelayGlitch = FindObjectOfType<AvoidDelayGlitch>();    
    }

    void Update()
    {
        if(Physics2D.OverlapCircle(transform.position + Vector3.right * offset, radius, wallMask))
        {
            plataformsMovements.enabled = true;
            avoidDelayGlitch.shouldDelay = true;
        }
        else
        {
            plataformsMovements.enabled = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position + Vector3.right * offset, radius);
    }
}
