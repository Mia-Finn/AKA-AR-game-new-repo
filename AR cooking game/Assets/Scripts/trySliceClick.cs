using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trySliceClick : MonoBehaviour
{
   // public GameObject knife, endCut, topBun, bottomBun, plate, storeTopBun, camera1, camera2;
   // Vector3 screenPosition;
    Vector3 knifePosition;

    private void Start()
    {
        /*
        if (Vector3.Distance(knife.transform.position, endCut.transform.position) < 2f)
        {
            topBun.transform.position = storeTopBun.transform.position;
        }
        */
    }

    //Store the screen position of the object when the mouse clicks
    void OnMouseDown()
    {
        knifePosition = Camera.main.WorldToScreenPoint(transform.position);
    }

    //When the mouse drags, change the object's screen position accordingly.
    void OnMouseDrag()
    {
        //Read the mouse input axes
        knifePosition.x += Input.GetAxis("Mouse X"); // - 0.2f;
       // knifePosition.y += Input.GetAxis("Mouse Y");

        //move the object to the world position to not change screen position
        transform.position = Camera.main.ScreenToWorldPoint(knifePosition);
    }

}
//Vector3(-0.970000029,0.449999988,-2.8599999)
//Vector3(0.955015182,0.200000048,-2.86710644)