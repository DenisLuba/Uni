using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    public Text fps;
    public float refreshTime = 0.5f;
    private int fpsCounter = 0;
    private float timeCounter = 0.0f;
    private float lastFrameRate = 0.0f;
    private const string FpsTextFormat = "{0} fps";
    
    // Update is called once per frame
    void Update()
    {
        if (timeCounter < refreshTime)
        {
            timeCounter += Time.deltaTime; 
            // Time.deltaTime:
            // The interval in seconds from the last frame to the current one (Read Only). 
            fpsCounter++;
        }
        else
        {
            lastFrameRate = fpsCounter / timeCounter;

            fpsCounter = 0;
            timeCounter = 0.0f;
        }

        fps.text = string.Format(FpsTextFormat, (int) lastFrameRate);
    }
}
