using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    [SerializeField] private Transform otherObject;
    private Vector3 respawnPoint;

    void Start()
    {
        respawnPoint = otherObject.transform.position;
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == otherObject.gameObject.name)
        {
            otherObject.transform.position = respawnPoint;
        }
    }
}
