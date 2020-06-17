using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Mov : MonoBehaviour
{
    //Character Movement and Speed 
    public CharacterController controller;
    public float speed = 6.0f;
    public float dashCD = 3.0f;
    public float dashTime;
    private Vector3 direction;
    
    
     
    
    private void Start() {
        
    }


    private void Update()
    {
        //Use arrow or AWSD as input and save in horizontal and vertical
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // Create a vector3 for save Horizontal an Vertical, Normalized to smooth
        direction = new Vector3(horizontal, 0f, vertical).normalized;

        // if (dashCD >= 5)
        // {
        // CD
        //if (CD = 0)
        //{
        //enemy atack
        //CD = 50;

        //} else {
        // CD -= 1;        
        //}

        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed += 10;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            speed -= 10;
        }
        /**   dashCD = 0;
           } else {
            dashCD += Time.deltaTime;
           }

       **/
    }
    private void FixedUpdate()
    {
        
         //This condicion check if the direction variable have new movements from our keys
        //If true we update the position of our player
        if (direction.magnitude >= 0.1f){

            controller.Move(direction * speed * Time.deltaTime);
        }

       
    }

     
}
