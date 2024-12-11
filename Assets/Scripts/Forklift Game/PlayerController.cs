using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    public Animator animator;
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
                if(this.gameObject.transform.position.x > ForkliftGameManger.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * LRSpeed);
                    animator.SetBool("PlayerLeft", true);
                    //Debug.Log(animator.GetBool("PlayerLeft"));
                }
            }
            if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
            {
                animator.SetBool("PlayerLeft", false);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if(this.gameObject.transform.position.x < ForkliftGameManger.rightSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * LRSpeed * -1);
                    animator.SetBool("PlayerRight", true);
                }
            }
            if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
            {
                animator.SetBool("PlayerRight", false);
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
