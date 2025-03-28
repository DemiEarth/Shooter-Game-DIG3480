using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //how to define a variable 

    //1. access modifier: public or private
    //2. data type: int, float, bool, string
    //3. variable name: camelCase
    //4. value: optional

    private float playerSpeed = 8.0f;
    private float horizontalInput;
    private float verticalInput;

    private float horizontalScreenLimit = 11.3f;
    private float verticalScreenLimit = 8f;


    void Start()
    {
        playerSpeed = 6f;
        // This function is called at the start of the game

    }
    void Update()

    {
        //This function is called every frame; 60 frames/second
        Movement();
    }

    void Movement()
    {
        // Read the input from the player

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Move the player
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * playerSpeed);
        //Player leaves the screen horizontally
        if (transform.position.x > horizontalScreenLimit || transform.position.x <= -horizontalScreenLimit)
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, 0);
        }
        //Player leavesthe screen vertically
        if (transform.position.y > 0 || transform.position.y <= -verticalScreenLimit)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
    }
}
