using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragToPlace : MonoBehaviour
{
    Vector3 ingredientPosition;

    void OnMouseDown()
    {
        ingredientPosition = Camera.main.WorldToScreenPoint(transform.position);
    }

    void OnMouseDrag()
    {
        ingredientPosition.x += Input.GetAxis("Mouse X"); // - 0.2f;
        ingredientPosition.y += Input.GetAxis("Mouse Y");
        transform.position = Camera.main.ScreenToWorldPoint(ingredientPosition);
    }
}
