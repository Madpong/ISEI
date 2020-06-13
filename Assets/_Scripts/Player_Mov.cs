using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Mov : MonoBehaviour
{
    //Character Movement and Speed 
    public CharacterController controller;
    public float speed = 6.0f;
    private Vector3 direction;
    
    public Camera cam;
    //Vector3 mousePos;
    public Vector3 v3Pos;
    
    private void Start() {
        cam = Camera.main;
    }


    private void Update() {
         //Use arrow or AWSD as input and save in horizontal and vertical
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        // Create a vector3 for save Horizontal an Vertical, Normalized to smooth
        direction = new Vector3(horizontal, 0f , vertical).normalized;

        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        //*Vector2 screenPosition = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
        ///Vector2 worldPosition = cam.ScreenToWorldPoint(screenPosition);
        //Debug.Log("M: " + worldPosition);

        ///var dist = Mathf.Abs(transform.position.y - cam.transform.position.z);
        ///v3Pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
        //v3Pos = Camera.main.ScreenToWorldPoint(v3Pos);

        
        
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
