using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("dead");
        player.gameObject.GetComponent<CharacterMovement>().enabled = false;
        player.position = respawnPoint.position;
        Invoke("EnableCharMovement", 0.01f);
        Debug.Log("deadw " + player.position);
    }

    void EnableCharMovement()
    {
        player.gameObject.GetComponent<CharacterMovement>().enabled = true;
    }
}
