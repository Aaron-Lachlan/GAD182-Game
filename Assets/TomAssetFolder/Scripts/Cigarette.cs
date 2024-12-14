using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Cigarette : MonoBehaviour
{
    [SerializeField]
    GameObject cigaretteModel;
    [SerializeField]
    GameObject cig1, cig2, cig3, cig4, cig5, cig6, cig7, cig8, cig9, cig10, cig11, cig12, cig13, cig14;
    
   public AudioSource cigClip1;

   

    // Start is called before the first frame update
    void Start()
    {

        // Creates a List of Cigarettes
        List<GameObject> cigPack = new List<GameObject>();

        //spawns 10 Cigarettes in Pack and their positions in the world

        GameObject c1 = Instantiate(cig1, new Vector3(5.35f, 19.82f, 10.50f), transform.rotation);
        cigPack.Add(c1);
        GameObject c2 = Instantiate(cig2, new Vector3(6.15f, 19.82f, 10.50f), transform.rotation);
        cigPack.Add(c2);
        GameObject c3 = Instantiate(cig3, new Vector3(6.95f, 19.82f, 10.50f), transform.rotation);
        cigPack.Add(c3);
        GameObject c4 = Instantiate(cig4, new Vector3(7.75f, 19.82f, 10.50f), transform.rotation);
        cigPack.Add(c4);
        GameObject c5 = Instantiate(cig5, new Vector3(8.55f, 19.82f, 10.50f), transform.rotation);
        cigPack.Add(c5);
        GameObject c6 = Instantiate(cig6, new Vector3(9.35f, 19.82f, 10.50f), transform.rotation);
        cigPack.Add(c6);
        GameObject c7 = Instantiate(cig7, new Vector3(10.15f, 19.82f, 10.50f), transform.rotation);
        cigPack.Add(c7);


        GameObject c8 = Instantiate(cig8, new Vector3(5.35f, 19.82f, 9.50f), transform.rotation);
        cigPack.Add(c8);
        GameObject c9 = Instantiate(cig9, new Vector3(6.15f, 19.82f, 9.50f), transform.rotation);
        cigPack.Add(c9);
        GameObject c10 = Instantiate(cig10, new Vector3(6.95f, 19.82f, 9.50f), transform.rotation);
        cigPack.Add(c10);
        GameObject c11 = Instantiate(cig11, new Vector3(7.75f, 19.82f, 9.50f), transform.rotation);
        cigPack.Add(c11);
        GameObject c12 = Instantiate(cig12, new Vector3(8.55f, 19.82f, 9.50f), transform.rotation);
        cigPack.Add(c12);
        GameObject c13 = Instantiate(cig13, new Vector3(9.35f, 19.82f, 9.50f), transform.rotation);
        cigPack.Add(c13);
        GameObject c14 = Instantiate(cig14, new Vector3(10.15f, 19.82f, 9.50f), transform.rotation);
        cigPack.Add(c14);



    }




    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cigClip1.Play();
        }

    }
   
}

