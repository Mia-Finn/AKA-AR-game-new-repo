using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliceFood : MonoBehaviour
{
    public Text touchText;
    private Touch screenTouched;
    private Vector2 touchStartPosition, touchEndPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            screenTouched = Input.GetTouch(0);

            if (screenTouched.phase == TouchPhase.Began)
            {
                touchStartPosition = screenTouched.position;
            }
            else if (screenTouched.phase == TouchPhase.Moved || screenTouched.phase == TouchPhase.Ended)
            {
                touchEndPosition = screenTouched.position;

                float x = touchEndPosition.x - touchStartPosition.x;
                float y = touchEndPosition.y - touchStartPosition.y;
            }
        }
    }
}
