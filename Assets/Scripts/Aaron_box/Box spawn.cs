using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Boxspawn : MonoBehaviour
{
    public GameObject Box;
    public Gamemanager Gamemanager;

    public Vector3 minBound;
    public Vector3 maxBound;

    private int spawnCount;

    // Start is called before the first frame update
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        Bounds bounds = renderer.bounds;

        minBound = bounds.min;
        maxBound = bounds.max;
        

        StartCoroutine(SpawnRepeatedly());
    }

    System.Collections.IEnumerator SpawnRepeatedly()
    {
        while (spawnCount < Gamemanager.NumOfSpawns)
        {
            Spawn();
            spawnCount++;
            yield return new WaitForSeconds(1.5f);
        }
        yield return new WaitForSeconds(3);
        Gamemanager.End();
    }


    void Spawn()
    {
        
        
            float x = Random.Range(minBound.x, maxBound.x);
            float y = Random.Range(minBound.y, maxBound.y);
            float z = Random.Range(minBound.z, maxBound.z);
            Vector3 SpawnArea = new Vector3(x, y, z);
            

            Instantiate(Box, SpawnArea, Quaternion.identity);

           
        
       
    }
}
