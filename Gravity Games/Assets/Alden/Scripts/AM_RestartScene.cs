using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AM_RestartScene : MonoBehaviour
{
    [SerializeField] private Transform Player;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform == Player)
        {
            Debug.Log("deadified");
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }
    }
}
