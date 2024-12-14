using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPack : MonoBehaviour
{
    [SerializeField]
    Animator openAnim;

    public GameObject textIcon;

    public AudioSource audioClip;
  

    // Start is called before the first frame update
    void Start()
    {
        /*
        openAnim = GetComponent<Animator>();
        */
    }

    // Update is called once per frame
    void Update()
    {
        OpenBox();
        
        
       TextToPlayer();
      
    }

    void OpenBox() 
    {
        if (Input.GetMouseButtonDown(1))
        {
            audioClip.Play();
            openAnim.SetTrigger("Open 0");
            Debug.Log("Box Open");
            
        }
        
    }

    void TextToPlayer() 
    {
        if(Input.GetMouseButtonDown(1))
        {
            textIcon.SetActive(false);
        }
        
            
        
    }

    void PlayerTimer() 
    {

    }


}
