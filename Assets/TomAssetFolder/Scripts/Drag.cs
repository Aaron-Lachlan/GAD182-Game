using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
     
    Vector3 mousePosition;

    //Getting mouse position 
    private Vector3 GetMousePos() 
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    // Mouse button to interact with a collider
    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
    }


    // Transforms the position of the object while player is holding down the mouse button on a collider
    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }
}
