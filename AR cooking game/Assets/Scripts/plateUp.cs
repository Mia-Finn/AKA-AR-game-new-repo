using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateUp : MonoBehaviour
{
    public GameObject knife, topBun, bottomBun, storeTopBun, storeBottomBun, camera1, camera2, lettuce, trigger1, trigger2, knifeOrigin;

    private void OnTriggerEnter(Collider withKnife)
    {
        topBun.transform.position = storeTopBun.transform.position;
        bottomBun.transform.position = storeBottomBun.transform.position;
        knife.transform.position = knifeOrigin.transform.position;

        trigger1.SetActive(false);
        trigger2.SetActive(true);
      //  lettuce.SetActive(true);

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
        */
    }
}