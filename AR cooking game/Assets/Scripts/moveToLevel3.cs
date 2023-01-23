using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveToLevel3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //SceneManager.LoadScene(8);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
