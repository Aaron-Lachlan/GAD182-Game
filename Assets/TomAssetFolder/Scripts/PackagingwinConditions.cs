using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackagingwinConditions : MonoBehaviour
{
    [SerializeField]
    public GameObject winIcon;
    [SerializeField]
    public GameObject box;

    public BoxCollider boxCollider;



    
    // Update is called once per frame
    public void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("Finish") || other.CompareTag("Mic") || other.CompareTag("Player"))
        {
            winIcon.SetActive(true);

        }
        




    }

}
