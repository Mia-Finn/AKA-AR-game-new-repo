using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sliceSceneText : MonoBehaviour
{
    public TMP_Text UIText;
    public string sliceText, dragText;
    public GameObject plateCamera;

    // Update is called once per frame
    void Update()
    {
       if(plateCamera.activeInHierarchy == false)
        {
            UIText.text = sliceText;
        }
        else
        {
            UIText.text = dragText;
        }
    }
}
