using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trySliceClick : MonoBehaviour
{
   // public GameObject knife, endCut, topBun, bottomBun, plate, storeTopBun, camera1, camera2;
   // Vector3 screenPosition;
    Vector3 knifePosition;

    private float knifeSpeed = 10;

    void OnMouseDown()
    {
        knifePosition = Camera.main.WorldToScreenPoint(transform.position);
    }

    void OnMouseDrag()
    {
        knifePosition.x += Input.GetAxis("Mouse X") * knifeSpeed;
       // knifePosition.y += Input.GetAxis("Mouse Y");

        transform.position = Camera.main.ScreenToWorldPoint(knifePosition);
    }

}