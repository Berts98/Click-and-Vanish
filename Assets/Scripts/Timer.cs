using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {


    public float currentTime = 0f;
    float startingTime = 15f;

    public Text CountDown;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        CountDown.text = currentTime.ToString("0.0");

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
