using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragToPlace : MonoBehaviour
{
    Vector3 ingredientPosition;

    private float dragSpeed = 10;

    void OnMouseDown()
    {
        ingredientPosition = Camera.main.WorldToScreenPoint(transform.position);
    }

    void OnMouseDrag()
    {
        ingredientPosition.x += Input.GetAxis("Mouse X") * dragSpeed;
        ingredientPosition.y += Input.GetAxis("Mouse Y") * dragSpeed;

        transform.position = Camera.main.ScreenToWorldPoint(ingredientPosition);
    }
}
