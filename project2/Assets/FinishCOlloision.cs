using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishCOlloision : MonoBehaviour
{
   public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Credits");
        }
    }
}
