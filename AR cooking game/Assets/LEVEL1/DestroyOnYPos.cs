using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnYPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -1.2)
        {
            Destroy(gameObject);
        }
    }
}
