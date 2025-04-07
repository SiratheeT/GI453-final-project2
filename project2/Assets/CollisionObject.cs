using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionObject : MonoBehaviour
{
    public ScoreUI scoreUI;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ammo")
        {
            scoreUI.score++;
            Object.Destroy(this.gameObject);
        }
    }

}
