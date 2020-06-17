 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 public class AIController : MonoBehaviour
{
    // This variables is changed to create diferents prefavs with Player target as default
    private GameObject Gplayer;
    public Transform Player;
    
    public float MoveSpeed = 4;
    public float MaxDist = 10;
    public float MinDist = 1;



    void Start()
    {
        Gplayer = GameObject.FindWithTag("Player");
        if (Gplayer != null)
        {
            Player = Gplayer.GetComponent<Transform>();
        }
       
    }

    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;



            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                //Here Call any function U want Like Shoot at here or something
            }

        }
    }
}