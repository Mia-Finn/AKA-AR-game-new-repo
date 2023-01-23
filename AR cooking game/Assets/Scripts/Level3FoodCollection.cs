using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Level3FoodCollection : MonoBehaviour
{
    public int ingredients;
    public TMP_Text UIText;

    private void OnTriggerEnter(Collider other)
    {
        //  Debug.Log("Working"); 

        //   UIText.text = collectionCounter + ingredientsCollected ++ ;

        if (other.tag == "rightItem")
        {
            // Debug.Log("Right Ingredient");

            ingredients = ingredients + 1;
            UIText.text = "Ingredients Collected : " + ingredients.ToString() + "/3";

            if (ingredients == 3)
            {
                //  Debug.Log("Collection is working");

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

        }
        else if (other.tag == "wrongItem")
        {
            //  Debug.Log("Wrong Ingredient");

            SceneManager.LoadScene(20);
        }
    }

    }
