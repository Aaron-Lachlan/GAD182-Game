using System.Collections;
using UnityEngine;

public class ThrowObjects : MonoBehaviour
{
    GameObject grabbedObject;
    float grabbedObjectSize;
    private Vector3 previousGrabPosition;

    GameObject GetMouseHoverObject(float range)
    {
        Vector3 position = gameObject.transform.position;
        RaycastHit raycastHit;
        Vector3 target = position + Camera.main.transform.forward * range;
        if (Physics.Linecast(position, target, out raycastHit))
            return raycastHit.collider.gameObject;
        return null;
    }
    void TryGrabObject(GameObject grabObject)
    {
        if (grabObject == null || !CanGrab(grabObject))
            return;
        grabbedObject = grabObject;
        grabbedObjectSize = grabbedObject.GetComponent<MeshRenderer>().bounds.size.magnitude;
        grabbedObject.GetComponent<Rigidbody>().useGravity = false;
        //Debug.Log(grabbedObject);
    }
    void DropObject()
    {
        if (grabbedObject == null)
            return;
        Rigidbody rb = grabbedObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            Vector3 throwVector = grabbedObject.transform.position - previousGrabPosition;
            float speed = throwVector.magnitude / Time.deltaTime;
            Vector3 throwVelocity = speed * throwVector.normalized;
            rb.velocity = throwVelocity;
            rb.useGravity = true;
        }
        grabbedObject = null;
    }

    bool CanGrab(GameObject candidate)
    {
        return candidate.GetComponent<Rigidbody>() != null;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Mouse Button");
            if(grabbedObject == null)
                TryGrabObject(GetMouseHoverObject(10));
            //else
                //DropObject();
        }
        if(Input.GetMouseButtonUp(0))
            DropObject();
        if(grabbedObject != null)
        {
            previousGrabPosition = grabbedObject.transform.position;
            Vector3 newPosition = gameObject.transform.position + Camera.main.transform.forward * grabbedObjectSize;
            grabbedObject.transform.position = newPosition;
        }
        
    }
}
