using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class finalscorefinder : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    //  public TMP_Text timerText;

    //public GameObject answer;

    private float answer = GameObject.Find("TimerHolder").GetComponent<timehold>().timer;

    void Start()
    {
        //float answer = GameObject.Find("TimerHolder").GetComponent<timehold>().timer;
        timerText.text = "Score: " + answer.ToString();
    }

    void Update()
    {
        
    }
}
