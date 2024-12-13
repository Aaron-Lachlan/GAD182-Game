using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CardBoardBox : MonoBehaviour
{
    [SerializeField]
    Animator animatorOne;
    [SerializeField]
    BoxCollider boxCollider;
    [SerializeField]
    GameObject winText, loseText;
    [SerializeField]
    GameObject helpText;
    public AudioSource audiClip;
    public int pointsW = 0;

    public TimerTwo timerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        timerScript.GetComponent<TimerTwo>();

    }

    // Update is called once per frame
    void Update()
    {
        if (timerScript.timeLeft <= 0) 
        {
            loseText.SetActive(true);

        }
        else
        {
            loseText.SetActive(false);
        }
        OpenCBox();
    }
    
     private void OnTriggerEnter(Collider other)
    {
        
        
        
        pointsW++;
        Debug.Log("1 point added");

        if (pointsW == 3)
        {
            winText.SetActive(true);
            timerScript.timerOn = false;

        }
        else 
        {
            winText.SetActive(false);
            

        }
        


    }

    void OpenCBox() 
    {
        if (Input.GetMouseButtonDown(1))
        {
            audiClip.Play();
            animatorOne.SetTrigger("Open 1");
            helpText.SetActive(false);

        }
       
    }
    
    }


