using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puase : MonoBehaviour
{
    public bool isPaused = false;

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
