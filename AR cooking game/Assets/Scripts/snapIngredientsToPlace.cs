using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class snapIngredientsToPlace : MonoBehaviour
{
    public TMP_Text UIText;
    public GameObject cheeseSlice;
    public string stackText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cheeseSlice.activeInHierarchy == true)
        {
            UIText.text = stackText;
        }
    }
}
