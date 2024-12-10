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

    public TextMeshProUGUI Text;
    private Vector3 initialPosition;
    private Vector3 directionOfShake;
    public float amplitude = 1.0f;
    public float frequency = 1.0f; 

    // Start is called before the first frame update
    void Start()
    {
        Vector3 directionOfShake = transform.forward;
        ProgressBar.value = count;

        initialPosition = Text.transform.position;
}
    void FixedUpdate()
    {
        Text.transform.position = initialPosition + directionOfShake * (-amplitude + Mathf.PingPong(frequency * Time.fixedDeltaTime, 2f * amplitude));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Pressed();
        }

    }

    public void Pressed()
    {

        count = count - 1;
        ProgressBar.value = count;


        SoundPitch = SoundPitch + 0.04f;
        Sound.pitch = SoundPitch;
        Sound.Play();
      




    }



}
