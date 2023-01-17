using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class foodCollected : MonoBehaviour
{
   // public GameObject bowl, food;
    public TMP_Text UIText;
    public string collectionCounter;

     private float ingredientsCollected = +1;

    private void OnTriggerEnter(Collider other)
    {
        //  Debug.Log("Working"); 

         UIText.text = collectionCounter + ingredientsCollected ++ ;
    }

    private void FixedUpdate()
    { 
        if(ingredientsCollected >= 3)
        {
            Debug.Log("Working");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
