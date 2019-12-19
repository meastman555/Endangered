using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cinematic : MonoBehaviour
{
    private int sceneIndex;
    private Animator myAnimator;

    //gets component and begins playing the cinematic animation
    //gets current scene index
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        myAnimator = GetComponent<Animator>();
        myAnimator.Play("StoryBoard");
    }

    //if space is pressed at all during the animation advances to the next scene by way of its scene index
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sceneIndex++;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
