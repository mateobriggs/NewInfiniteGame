using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce;
    private Rigidbody2D rb;
    public float radius;
    public LayerMask floorMask;
   // public LayerMask wallMask;
    public float offset;
    //public AudioSource playerJump;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        if (Physics2D.OverlapCircle(transform.position + Vector3.down * offset, radius, floorMask))
        {
            //playerJump.Play();
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    public void ConterJump()
    {
        if (!Physics2D.OverlapCircle(transform.position + Vector3.down * offset, radius, floorMask))
        {
            //playerJump.Play();
            rb.AddForce(Vector2.down * jumpForce * 2, ForceMode2D.Impulse);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position + Vector3.down * offset, radius);
    }
}