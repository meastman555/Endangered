using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterVictoryScreen : MonoBehaviour
{
    //if space is pressed at all during the animation advances to the next scene
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("EndTitle");
        }
    }
}
