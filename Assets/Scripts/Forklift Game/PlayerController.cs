using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed = 3;
    public float LRSpeed = 4;
    static public bool canMove = false;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        direction.z = forwardSpeed;

        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.back * Time.deltaTime * LRSpeed);
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.back * Time.deltaTime * LRSpeed * -1);
            }
        }
    }
    void FixedUpdate()
    {
        if (canMove == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed, Space.World);
        }
        //controller.Move(direction*Time.deltaTime);
    }
}
