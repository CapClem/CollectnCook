using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayTimer : MonoBehaviour
{
    //Make Timer

    public float cdTimer = 300;
    public bool timerActive = false; 
    //Declare Day and Night
    public bool isDay = true;
    //Countdown during day
    //Paused time during night
    //Fade transition during both phases optional


    // Start is called before the first frame update
    void Start()
    {
        //this starts the timer
        timerActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive && isDay == true)
        {
            if (cdTimer > 0)
            {
                cdTimer -= Time.deltaTime;
            }
            else
            {
                isDay = false;
            }
        }
        else
        {
            Debug.Log("Day Time is Over");
            cdTimer = 0;
            timerActive = false;
            isDay = false;
        }
        
        //Rotates the mf Sun
         transform.eulerAngles = new Vector3 (170 - (cdTimer/2), -112, 0);

        if (isDay == false)
        {
            transform.eulerAngles = new Vector3();
        }
    }
}
