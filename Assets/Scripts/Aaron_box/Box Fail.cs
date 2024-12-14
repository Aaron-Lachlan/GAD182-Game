using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxFail: MonoBehaviour
{
    //game obj's
    public GameObject BoxPrefab;
    public Collider TriggerFail;
    public Gamemanager Gamemanager;

    public void OnTriggerEnter(Collider other)
    {
        Gamemanager.failedPoints++;
        //Destroy(BoxPrefab);
    }

}
