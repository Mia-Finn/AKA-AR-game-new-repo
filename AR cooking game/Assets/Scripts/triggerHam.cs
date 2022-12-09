using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerHam : MonoBehaviour
{
    public GameObject knife1, knife2, knife3, knife4, topBun, bottomBun, storeTopBun, storeBottomBun, camera1, camera2, lettuce, lettuceSlice, ham, hamSlice, cheese, cheeseSlice;

    private float timer = 0f;

    private enum levelStages
    {
        BREAD, LETTUCE, HAM, CHEESE, END
    }
    

    private levelStages currentStage = levelStages.BREAD;

    private void OnTriggerEnter(Collider other)
    {
        switch (currentStage)
        {
            case levelStages.BREAD:

                topBun.transform.position = storeTopBun.transform.position;
                bottomBun.transform.position = storeBottomBun.transform.position;

                currentStage = levelStages.LETTUCE;

                break;

            case levelStages.LETTUCE:

                knife1.SetActive(false);
                knife2.SetActive(true);
                lettuce.SetActive(true);

                currentStage = levelStages.HAM;

                break;

            case levelStages.HAM:

                knife2.SetActive(false);
                knife3.SetActive(true);

                lettuce.SetActive(false);
                lettuceSlice.SetActive(true);
                ham.SetActive(true);

                currentStage = levelStages.CHEESE;

                break;

            case levelStages.CHEESE:

                knife3.SetActive(false);
                knife4.SetActive(true);

                ham.SetActive(false);
                hamSlice.SetActive(true);
                cheese.SetActive(true);

                currentStage = levelStages.END;

                break;

            case levelStages.END:

                cheeseSlice.SetActive(true);
                camera1.SetActive(false);
                camera2.SetActive(true);

                /*
                timer = Time.deltaTime;

                if(timer > 5f)
                {
                    SceneManager.LoadScene(1);
                }
                */

                break;
        }
    }


    /*
    private void Update()
    {
        switch (currentStage)
        {
            case levelStages.BREAD:

                break;
    }
    */






    /*
    public GameObject trigger2, trigger3, lettuce, lettuceSlice, ham, hamSlice, knife, knifeOrigin;

    private void Start()
    {
        lettuce.SetActive(true);
       // knife.transform.position = knifeOrigin.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        trigger2.SetActive(false);
        trigger3.SetActive(true);
       // lettuceSlice.SetActive(true);
       // lettuce.SetActive(false);
       // ham.SetActive(true);

        // camera1.SetActive(false);
        // camera2.SetActive(true);
        // knife.SetActive(false);

        /*
        lettuce.SetActive(true);

        if (lettuce.activeInHierarchy == true && lettuceSlice.activeInHierarchy == false)
        {
            lettuceSlice.SetActive(true);
            ham.SetActive(true);
        }
        
    }
    */


}