using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterGame : MonoBehaviour
{
    //loads different scenes/quits the game depending on if certain buttons are pressed while at the title screen
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Intro");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Credits");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }
}
