using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scorehandler : MonoBehaviour
{
    public GameObject currentScore;

    private TextMeshPro currentScoreText;

    // Start is called before the first frame update
    void Start()
    {
        currentScoreText = currentScore.GetComponent<TextMeshPro>();


        currentScoreText.text = PlayerPrefs.GetString("currentScore");
    }


}
