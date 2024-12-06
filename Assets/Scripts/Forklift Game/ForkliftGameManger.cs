using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForkliftGameManger : MonoBehaviour
{
    public static float leftSide = -4f;
    public static float rightSide = 4f;
    public float internalLeft;
    public float internalRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
        if(PlayerController.canMove == true)
        {
            Debug.Log("DRIVING");
        }

        if(PlayerController.canMove == false)
        {
            Debug.Log("LOOSER");
        }
    }
}
