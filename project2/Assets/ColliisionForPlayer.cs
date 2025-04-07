using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ColliisionForPlayer : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            Destroy (GameObject.FindWithTag("Player"));
            SceneManager.LoadScene(1);
        }
    }
}
