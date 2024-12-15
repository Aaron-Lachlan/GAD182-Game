using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerInput : MonoBehaviour
{

    //settings
    public int MaxClicks;
    private bool gameEnded = false;
    public PlayerPointSystemSO scoreSO;

    //UI
    public UnityEngine.UI.Slider ProgressBar;
    private int count;


    //sfx
    private float SoundPitch = 1.0f;
    public AudioSource Sound;

    //Timer
    public TMPro.TextMeshProUGUI TextTimer;
    public float Timer;

    // Text animation 
    public Transform Text;
    private Vector3 initialPositionTxt;
    private Vector3 directionOfShake = Vector3.up;
    private float amplitude = 0.01f;
    private int frequency = 2;

    //character animation
    public GameObject Character;
    private Vector3 initialPositionChr;
    // Start is called before the first frame update
    void Start()
    {
        count = MaxClicks;
        ProgressBar.maxValue = MaxClicks;
        ProgressBar.value = count;

        initialPositionTxt = Text.position;



    }


    // Update is called once per frame
    void Update()
    {

        if (!gameEnded)
        {
            Text.position = initialPositionTxt + directionOfShake * Mathf.PingPong(Time.time * frequency, amplitude * 2f);
            Character.transform.position = initialPositionChr + Vector3.right * Mathf.PingPong(Time.time * frequency, amplitude * 1.001f);
        }
        if (Input.GetKeyDown(KeyCode.Space) == true && !gameEnded)
        {
            Pressed();
        }


        if (count > 0)
        {
            Timer += Time.deltaTime;
            TextTimer.text = Timer.ToString("F2");
        }
        else if (!gameEnded)
        {
            gameEnded = true;
            Sound.Pause();


            
            scoreSO.Score += Mathf.RoundToInt(1000/Timer);
            
        }

    }

    public void Pressed()
    {

        count += -1;
        ProgressBar.value = count;

        //text shake 
        frequency += 10;
        amplitude += 0.1f;

        //sfx
        SoundPitch = SoundPitch + 0.04f;
        Sound.pitch = SoundPitch;
        Sound.Play();
      
    }



}
