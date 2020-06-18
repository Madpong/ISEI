using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TEstDash : MonoBehaviour
{

    private CharacterController cc;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direcction;


    private bool dash;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        dashTime = startDashTime;
        dash = false;
     }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { dash = true;}
        if (Input.GetKeyUp(KeyCode.Space)) { dash = false;}

        if (direcction == 0)
        {
            //if (dash)
            
                if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) { direcction = 1; }
                else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) { direcction = 2; }
                else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) { direcction = 3; }
                else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) { direcction = 4; }
            
        }else {
            if(dashTime <= 0)
            {
                direcction = 0;
                dashTime = startDashTime;
                cc.Move(Vector3.zero);
            }else {
                dashTime -= Time.deltaTime;
                
                    if (direcction == 1) { cc.Move(Vector3.left * dashSpeed * Time.deltaTime); }
                    if (direcction == 2) { cc.Move(Vector3.right * dashSpeed * Time.deltaTime); }
                    if (direcction == 3) { cc.Move(Vector3.forward  * dashSpeed * Time.deltaTime); }
                    if (direcction == 4) { cc.Move(Vector3.back * dashSpeed * Time.deltaTime); }
               
            }
        }
    }
}
