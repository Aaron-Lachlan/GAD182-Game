using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class CigaretteDestroyer : MonoBehaviour
{
  
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    

    private void OnMouseDown()
    {
        Destroy(gameObject);
       
    }
  
}
