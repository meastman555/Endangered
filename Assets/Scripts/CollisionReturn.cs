using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionReturn : MonoBehaviour
{
    int sceneIndex;

    //gets the current scene index
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    //if the player collides with the part and presses return, load the next scene by way of its scene index
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player") && Input.GetKeyDown(KeyCode.Return))
        {
            sceneIndex++;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
