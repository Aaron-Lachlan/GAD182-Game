using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class Timer : MonoBehaviour
{
    public float timeLeft;
    public bool timerOn = false;

    [SerializeField]
    public TextMeshProUGUI timerText;
    [SerializeField]
    GameObject winText;
    [SerializeField]
    GameObject loseText;
    [SerializeField]
    ParticleSystem paricleSystem;

   public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        
            timerOn = true;
       


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
       
        
        if (GameObject.FindGameObjectsWithTag("Cigarette").Length <= 0 & timeLeft > 0)
        {
            
            paricleSystem.Play();
            AudioSource.PlayClipAtPoint(audioClip, new Vector3(0, 0, 0));
            winText.SetActive(true);
            loseText.SetActive(false);
            timerOn = false;
            
        }
        else if (timeLeft <= 0) 
        {
            winText.SetActive(false);
            loseText.SetActive(true);
            
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
