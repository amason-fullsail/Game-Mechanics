using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public float fallTimer = 1.5f;

    void OnTriggerEnter(Collider collidedWithThis)
    {
        Debug.Log("COLLIDE WITH: " + collidedWithThis.gameObject.tag);
        if (collidedWithThis.gameObject.tag == "Player")
        {
            StartCoroutine(FallAfterDelay());
        }
    }
    
    IEnumerator FallAfterDelay()
    {
        yield return new WaitForSeconds(fallTimer);
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
