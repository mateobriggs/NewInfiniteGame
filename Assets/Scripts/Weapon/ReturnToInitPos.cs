using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToInitPos : MonoBehaviour
{
    public int returnPosibilities;
    public AvoidDelayGlitch avoidDelayGlitch;

    private void Start()
    {
        avoidDelayGlitch = GetComponent<AvoidDelayGlitch>();
    }

    public void ReturnToPos0()
    {
        if (returnPosibilities > 0)
        {
            transform.position = new Vector3(0f, transform.position.y, transform.position.z);
            avoidDelayGlitch.shouldDelay = false;
            returnPosibilities--;
            if (returnPosibilities == 0)
            {
                GameObject playerGhost = GameObject.Find("PlayerGhost");
                playerGhost.GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }
}
