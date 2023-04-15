using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePickup : MonoBehaviour
{
    public float range = 20;
    public float throwPower = 10;
    public Transform handTransform;

    public Transform rayOrigin;
    private GameObject pickedUpItem = null;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (pickedUpItem == null)
            {
                RaycastHit hit;
                if (Physics.Raycast(rayOrigin.position, rayOrigin.transform.forward, out hit, range))
                {
                    if (hit.collider.GetComponent<IPickup>() != null)
                    {
                        pickedUpItem = hit.collider.gameObject;
                        pickedUpItem.GetComponent<IPickup>().Pickup(handTransform);
                    }
                    
                }
            }
            else
            {
                pickedUpItem.GetComponent<IPickup>().Drop(throwPower);
                pickedUpItem = null;
            }
        }
    }
}
