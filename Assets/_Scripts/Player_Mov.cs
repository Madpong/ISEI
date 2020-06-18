using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Mov : MonoBehaviour
{
    //Character Movement and Speed 
    public CharacterController controller;
    public float speed = 6.0f;
    private Vector3 direction;

    public float dashCD = 5000;
    public float dashTime = 0;
   // private bool isDash = false;
    public Vector3 dashMove;
    




    private void Start() {

    }


    private void Update()
    {
        //Use arrow or AWSD as input and save in horizontal and vertical
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // Create a vector3 for save Horizontal an Vertical, Normalized to smooth
        direction = new Vector3(horizontal, 0f, vertical).normalized;

       /* if (Input.GetKeyDown(KeyCode.Space)) {
            isDash = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            isDash = false;
        
        } else {
            dashTime -= Time.deltaTime;
            ///Debug.Log("dashTime" + dashTime);
        }

       
         if (dashTime <= 0)
        {

            //isDash = false;
        }
        else {

           // dashTime -= Time.deltaTime;

        }
        */
        
            //
            //Debug.Log("START DASH");


        /** else {
            dashTime -= Time.deltaTime;
        }**/


    }
    private void FixedUpdate()
    {

        //This condicion check if the direction variable have new movements from our keys
        //If true we update the position of our player
       // if (isDash) {
          // controller.Move(direction * speed * 8 * Time.deltaTime);
           
        //}
        
        if (direction.magnitude >= 0.1f) {
           
                controller.Move(direction * speed * Time.deltaTime);
           
        }
        

    }

    void dash() {

         { 
            if (dashTime <= 0){

            Debug.Log("Dash");
                dashTime = dashCD;
                //speed = 20f;
                dashTime = dashCD;
            }
        }


    }


} 


/**if (isDash)
            {
                dash();
isDash = false;
         
**/