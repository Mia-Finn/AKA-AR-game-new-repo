using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level2FoodCollected : MonoBehaviour
{
    public int ingredients;

    private void OnTriggerEnter(Collider other)
    {
        //  Debug.Log("Working"); 

        //   UIText.text = collectionCounter + ingredientsCollected ++ ;

        if (other.tag == "rightItem")
        {
           //  Debug.Log("Right Ingredient");

            ingredients = ingredients + 1;

            if (ingredients == 3)
            {
                //  Debug.Log("Collection is working");

                SceneManager.LoadScene(7);
            }

        }
        else if (other.tag == "wrongItem")
        {
             // Debug.Log("Wrong Ingredient");

            SceneManager.LoadScene(4);
        }

    }
}
