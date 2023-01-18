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

        if (other.tag == "rightItem")
        {
             Debug.Log("Right Ingredient");

            SceneManager.LoadScene(3);
        }
        else if (other.tag == "wrongItem")
        {
             Debug.Log("Wrong Ingredient");

            SceneManager.LoadScene(4);
        }

    }

    private void FixedUpdate()
    { 
        if(ingredientsCollected == 3)
        {
            Debug.Log("Collection is working");

           // SceneManager.LoadScene(2);
        }
    }
}
