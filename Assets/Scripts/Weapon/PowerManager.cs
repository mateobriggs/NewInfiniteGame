using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PowerManager : MonoBehaviour
{
    public int bullets = 2;
    public Rigidbody2D bullet;
    public float force;

    public void ShootBullet()
    {
        if (bullets > 0)
        {
            Rigidbody2D bulletShot = Instantiate(bullet, transform.position + new Vector3(0.5f, 0, 0), Quaternion.identity);
            bulletShot.AddForce(Vector3.right * force, ForceMode2D.Impulse);
            bullets--;
            FindObjectOfType<GamePlayInformation>().UpdateBullets(bullets.ToString());
            if (bullets == 0)
            {
                gameObject.transform.GetChild(0).gameObject.SetActive(false);
            }
        }
        else return; 
    }

    public void CrossWall()
    {

    }
}
