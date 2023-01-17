using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerHam : MonoBehaviour
{
    public GameObject knife1, knife2, knife3, knife4, topBun, bottomBun, storeTopBun, storeBottomBun, camera1, camera2, lettuce, lettuceSlice, ham, hamSlice, cheese, cheeseSlice;

    //private float timer = 0f;

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

                Debug.Log("Running Code");

                currentStage = levelStages.END;

                break;

            case levelStages.END:

                knife4.SetActive(false);
                camera1.SetActive(false);
                camera2.SetActive(true);

                cheese.SetActive(false);
                cheeseSlice.SetActive(true);
               // topBun2.SetActive(true);

                break;
        }
    }

}
