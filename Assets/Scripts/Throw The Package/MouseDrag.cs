using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MouseDrag : MonoBehaviour {
 
    Rigidbody rb;
    Vector3 mousePosition;
 
    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }
 
}