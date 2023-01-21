using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2SlicingTriggers : MonoBehaviour
{
    public GameObject knife1, knife2, knife3, knife4, knife5, topBun, bottomBun, storeTopBun, storeBottomBun, camera1, camera2, lettuce, lettuceSlice, burger, burgerSlice, cheese, cheeseSlice, tomato, tomatoSlice, mayo;

    //private float timer = 0f;

    private enum levelStages
    {
        BREAD, BURGER, CHEESE, LETTUCE, TOMATO, END
    }


   // private levelStages currentStage = levelStages.BREAD;

    private void OnTriggerEnter(Collider other)
    {
        /*
        switch (currentStage)
        {
            case levelStages.BREAD:

                topBun.transform.position = storeTopBun.transform.position;
                bottomBun.transform.position = storeBottomBun.transform.position;

                currentStage = levelStages.BURGER;

                break;

            case levelStages.BURGER:

                knife1.SetActive(false);
                knife2.SetActive(true);
                burger.SetActive(true);

                currentStage = levelStages.LETTUCE;

                break;

            case levelStages.LETTUCE:

                knife2.SetActive(false);
                knife3.SetActive(true);

                burger.SetActive(false);
                burgerSlice.SetActive(true);
                lettuce.SetActive(true);

                currentStage = levelStages.CHEESE;

                break;

            case levelStages.CHEESE:

                knife3.SetActive(false);
                knife4.SetActive(true);

                lettuce.SetActive(false);
                lettuceSlice.SetActive(true);
                cheese.SetActive(true);

               // Debug.Log("Running Code");

                currentStage = levelStages.TOMATO;

                break;

            case levelStages.TOMATO:

                knife4.SetActive(false);
                knife5.SetActive(true);

                cheese.SetActive(false);
                cheeseSlice.SetActive(true);
                tomato.SetActive(true);

                Debug.Log("Running Code");

                currentStage = levelStages.END;

                break;

            case levelStages.END:

                knife5.SetActive(false);
                camera1.SetActive(false);
                camera2.SetActive(true);

                tomato.SetActive(false);
                tomatoSlice.SetActive(true);
                mayo.SetActive(true);
                // topBun2.SetActive(true);

                break;

        }
        */

        if(knife1.activeInHierarchy == true)
        {
            topBun.transform.position = storeTopBun.transform.position;
            bottomBun.transform.position = storeBottomBun.transform.position;

            knife1.SetActive(false);
            knife2.SetActive(true);

            burger.SetActive(true);
        }
        else if (knife2.activeInHierarchy == true)
        {
            knife2.SetActive(false);
            knife3.SetActive(true);

            burger.SetActive(false);
            burgerSlice.SetActive(true);
            lettuce.SetActive(true);
        }
        else if (knife3.activeInHierarchy == true)
        {
            knife3.SetActive(false);
            knife4.SetActive(true);

            lettuce.SetActive(false);
            lettuceSlice.SetActive(true);
            cheese.SetActive(true);
        }
        
        if (knife4.activeInHierarchy == true)
        {
            knife4.SetActive(false);
            knife5.SetActive(true);

            cheese.SetActive(false);
            cheeseSlice.SetActive(true);
            tomato.SetActive(true);
        }
       else if (knife5.activeInHierarchy == true)
        {       
                knife5.SetActive(false);
                camera1.SetActive(false);
                camera2.SetActive(true);

                tomato.SetActive(false);
                tomatoSlice.SetActive(true);
                mayo.SetActive(true);
        }
       
    }
}
