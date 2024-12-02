using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    void PauseGame()
    {
        if (Input.GetKeyDown("Escape"))
        {
            Time.timeScale = 0;
        }
    }
}
