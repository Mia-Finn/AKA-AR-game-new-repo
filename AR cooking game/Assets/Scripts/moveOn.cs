using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveOn : MonoBehaviour
{
    // public GameObject bun, cheese;

   // private float timer = 0f;

    /*
    void Update()
    {
        bool bunPlaced = Vector3.Distance(bun.transform.position, cheese.transform.position) >= 10f;

        if (bunPlaced)
        {
            Debug.Log("Bun Placed!");

           //SceneManager.LoadScene(2);
        }
    }
    */
    
    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Bun Placed!");
        /*
        timer = Time.time;

        if(timer >= 5f)
        {
            SceneManager.LoadScene(5);
        }
        */

        SceneManager.LoadScene(5);
    }

}
