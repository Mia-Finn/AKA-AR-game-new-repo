using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class finalscorefinder : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TMP_Text timerText;

    //public GameObject answer;

    void Start()
    {
        float answer = GameObject.Find("TimerHolder").GetComponent<timehold>().timer;
        timerText.text = answer.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
