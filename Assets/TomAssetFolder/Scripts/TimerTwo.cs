using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerTwo : MonoBehaviour
{

    public float timeLeft;
    public bool timerOn = false;
    [SerializeField]
    TextMeshProUGUI timerText;

    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                updateTimer(timeLeft);
            }
            else
            {
                Debug.Log("Time is UP");
                timeLeft = 0;
                timerOn = false;
            }
        }
        // Updates the timer
        void updateTimer(float currentTime)
        {
            //set current time
            currentTime += 1;


            float seconds = Mathf.FloorToInt(currentTime % 60);

            // Displays Timer in game
            timerText.text = timeLeft.ToString("0");
        }

    }
   
}

