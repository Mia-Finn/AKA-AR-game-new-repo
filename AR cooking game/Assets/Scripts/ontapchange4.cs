using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ontapchange4 : MonoBehaviour
{
    public UnityEvent action;
    public GameObject score;
    private TextMesh scoreText;

    private void Start()
    {
        scoreText = score.GetComponent<TextMesh>();
        PlayerPrefs.SetString("currentScore", "500");
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                PlayerPrefs.SetString("currentScore", scoreText.text);
                GameObject obj = hit.collider.gameObject;
                SceneManager.LoadScene("Level4SpawnerScene");

            }
        }
    }
}