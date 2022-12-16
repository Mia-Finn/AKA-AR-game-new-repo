using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragItem : MonoBehaviour
{
    // Vector3 screenPosition;
    // Vector3 itemPosition;
    Vector3 mousePositionOffset;

    private Vector3 GetMouseWorldPostion()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseDown()
    {
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPostion();

      //  itemPosition = Camera.main.WorldToScreenPoint(transform.position);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPostion() + mousePositionOffset;

        /*
        itemPosition.x += Input.GetAxis("Mouse X");
        transform.position = Camera.main.ScreenToWorldPoint(itemPosition);
        */
    }
}
