using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class timehold : MonoBehaviour
{

    public float timer = 100f;
    bool timingtime = false;

    [SerializeField] TMP_Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        
        DontDestroyOnLoad(gameObject);
        timingtime = true;
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "EndMenu")
        {
            timingtime = false;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timingtime == true)
        {
            timer -= Time.deltaTime;
        }
       
        
        
    }
}
