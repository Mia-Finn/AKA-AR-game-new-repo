using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class foodCollected : MonoBehaviour
{
    public GameObject bowl, food;
    public TMP_Text UIText;
    public string collectionCounter;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(bowl.transform.position, food.transform.position) < 1f)
        {
            food.SetActive(false);
            UIText.text = collectionCounter;
        }
    }
}
