using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AM_SplashTimer : MonoBehaviour
{
    public float sceneLength = 5.0f; 

    
    void Update()
    {
        sceneLength -= Time.deltaTime;

        if (sceneLength <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        SceneManager.LoadScene("EC_MainMenuScene", LoadSceneMode.Additive);
    }
}
