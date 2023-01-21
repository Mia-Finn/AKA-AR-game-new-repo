using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3SlicingTriggers : MonoBehaviour
{
    public GameObject knife1, knife2, knife3, knife4, knife5, knife6, knife7, knife8, topBun, bottomBun, storeTopBun, storeBottomBun, camera1, camera2;
    public GameObject lettuce, lettuceSlice, burger, burgerSlice, cheese, cheeseSlice, mayo, egg, mushroom, mushroomSlice, bacon, baconSlice, onion, onionSlice;

    private void OnTriggerEnter(Collider other)
    {
        if (knife1.activeInHierarchy == true)
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
            onion.SetActive(true);
        }
        else if (knife5.activeInHierarchy == true)
        {
            knife5.SetActive(false);
            knife6.SetActive(true);

            onion.SetActive(false);
            onionSlice.SetActive(true);
            bacon.SetActive(true);
        }
        else if(knife6.activeInHierarchy == true)
        {
            knife6.SetActive(false);
            knife7.SetActive(true);

            bacon.SetActive(false);
            baconSlice.SetActive(true);
            mushroom.SetActive(true);
        }
        else if (knife7.activeInHierarchy == true)
        {
            knife7.SetActive(false);
            camera1.SetActive(false);
            camera2.SetActive(true);

            mushroom.SetActive(false);
            mushroomSlice.SetActive(true);
            mayo.SetActive(true);
            egg.SetActive(true);
        }
        

    }
}
