using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EC_PauseMenu : MonoBehaviour
{

    bool paused = false;

    public GameObject canvas;
    bool showCanvas = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            paused = togglePause();
            showCanvas = toggleShowCanvas();
        }
    }

    bool togglePause()
    {
        if(Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            return (false);
        }
        else
        {
            Time.timeScale = 0f;
            return (true);
        }
    }

    bool toggleShowCanvas()
    {
        if(showCanvas == false)
        {
            canvas.SetActive(true);
            return (true);
        }
        else
        {
            canvas.SetActive(false);
            return (false);
        }
    }

}
