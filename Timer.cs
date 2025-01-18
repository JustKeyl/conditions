using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float seconds = 0;
    int minutes = 1;

    void Update()
    {
        seconds -= Time.deltaTime;

        if (seconds<0)
        {
            if (minutes > 0)
            {
                minutes -= 1;
                seconds += 59;
            }
            else
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }
        
    }
}
