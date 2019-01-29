using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform == Player)
        {
            Debug.Log("dead");
            Player.gameObject.GetComponent<CharacterMovement>().enabled = false;
            Player.position = respawnPoint.position;
            Invoke("EnableCharMovement", 0.01f);
            Debug.Log("deadw " + Player.position);
        }
    }

    void EnableCharMovement()
    {
        Player.gameObject.GetComponent<CharacterMovement>().enabled = true;
    }





}



