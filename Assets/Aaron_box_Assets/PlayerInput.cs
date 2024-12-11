using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class PlayerInput : MonoBehaviour
{
    public int count = 100;
   
    public UnityEngine.UI.Slider ProgressBar;

    private float SoundPitch = 1.0f;
    public AudioSource Sound;

    //text Shake
    //public TextMeshProUGUI Text;
    public Transform Text;
    private Vector3 initialPosition;
    private Vector3 directionOfShake = Vector3.up;
    private float amplitude = 0.01f;
    private int frequency = 2;

    // Start is called before the first frame update
    void Start()
    {
        
        ProgressBar.value = count;

        initialPosition = Text.position;

    }
  

    // Update is called once per frame
    void Update()
    {

        Text.position = initialPosition + directionOfShake * Mathf.PingPong(Time.time * frequency, amplitude * 2f);
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Pressed();
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
