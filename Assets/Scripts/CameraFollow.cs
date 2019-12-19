using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //allows for the correct gameobject that the camera should follow to be set from the inspector
    public Transform playerAlien;
 
    // Update is called once per frame
    void Update()
    {
        //every frame the camera's position is tied to the center of the player's position
        transform.position = new Vector3(playerAlien.position.x, playerAlien.position.y, transform.position.z);
        //allows the game to be quit from gameplay
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }
}
