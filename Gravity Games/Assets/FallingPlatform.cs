using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public float fallTimer = 1.5f;

    void OnCollisionEnter(Collision collidedWithThis)
    {
        if (collidedWithThis.gameObject.tag == "Player")
        {
            StartCoroutine(FallAfterDelay());
        }
    }
    
    IEnumerator FallAfterDelay()
    {
        yield return new WaitForSeconds(fallTimer);
        GetComponent<Rigidbody>().isKinematic = false;
        Debug.Log("big anime titty");
    }
}
