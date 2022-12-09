using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallDown : MonoBehaviour
{
    // GameObject bowl, food;
    float yPos;

    void Start()
    {

    }

    void Update()
    {
        //get the current x coordinate from the transform component
        yPos = transform.position.y;
        //now set the position vector to an incremental x value
        transform.position = new Vector3(0, yPos - 0.009f, 0);

        /*
        if(Vector3.Distance(bowl.transform.position, food.transform.position)<0.5f)
        {
            food.SetActive(false);
        }
        */
    }
}
