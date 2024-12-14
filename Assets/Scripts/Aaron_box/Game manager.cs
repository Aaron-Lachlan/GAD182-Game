using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    
    public int NumOfSpawns;

    //dont touch
    public int failedPoints;
    public PlayerPointSystemSO scoreSO;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void End()
    {
        scoreSO.Score += (NumOfSpawns - failedPoints)*10;
    }
}
