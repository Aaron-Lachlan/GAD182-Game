using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public Animator playerAnimator;
    public LevelStarter gameTimer;
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerController>().enabled = false;
        PlayerController.canMove = false;
        gameTimer.isWinner = false;
        StopCoroutine(gameTimer.GameTimerSequence());
        StartCoroutine(gameTimer.GameComplete());
        Debug.Log("Loss");
        //playerAnimator.SetBool("PlayerCrash", true);
    }
    
}
