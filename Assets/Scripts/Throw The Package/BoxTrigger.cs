using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class BoxTrigger : MonoBehaviour
{
    public GameObject[] boxes;
    public GameObject box;
    public GameObject scoreDisplay;
    public Transform spawnLocation;
    public int playerScore;
    public int boxNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Box")
        {
            //boxNum = Random.Range(0, 3);
            //Instantiate(boxes[boxNum], spawnLocation.position, spawnLocation.rotation);
            Instantiate(box, spawnLocation.position, spawnLocation.rotation);
            playerScore += 1;
            scoreDisplay.GetComponent<Text>().text = "" + playerScore;
            //Destroy(other.gameObject, 3f);
        }
        Debug.Log(playerScore);
    }
}
