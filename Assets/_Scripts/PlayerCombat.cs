using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class PlayerCombat : MonoBehaviour
{
    //The first One Load the Commponent to manage the animations and change States   
    public Animator animator;
    //This bolean is used to check when the player is Holding Block Button
    private bool isBlocking = false;

    public int weaponDmg; 

    void Start() {
        //We load the Animator for later use and we save that commponent in animator
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Here is our main Actions Character Controller
        // This one Check if we click left mouse Button to Attack
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // This function trigger the attack animation
            PerformWeaponAttack();
        }

        // This check if we are holding our Block Botton
        if (Input.GetKey(KeyCode.C) && !isBlocking)
        {
            // This trigger the block Animation
            PerformBlock();
        }
        //this check if we Stop Hold our Block button, then stop Blocking state 
        else if (Input.GetKeyUp(KeyCode.C) && isBlocking)
        {
            notBlock();
           
        }
    }
    public void PerformWeaponAttack() {
        animator.SetTrigger("base_ATK");
        Debug.Log("Basic Attack!");

    }

    public void PerformBlock()
    {
        isBlocking = true;
        animator.SetTrigger("block");
        Debug.Log("Blocking Attacks!");
     }

    public void notBlock()
    {
        isBlocking = false;
        animator.SetTrigger("notBlocking");
        Debug.Log("not Bloking any more");
    }

    // THIS SCRIPT IS GOING TO SEND TRIGGER EVENTS 
    // When the sword hit anything with "tag" Enemy
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy") { 
            Debug.Log("Hit: " + other.name);
            // To Do

            //Do Damage 
            other.GetComponent<Ienemy>().TakeDamaga(weaponDmg);
            //Block Damge if we are in Block State

            // Parry.... hehe
        }
    }


}


    /*
     * This other method that i should check in futere. 
     * I dont really know why doesnt work with 3D
     * void Attack()
    {
        //animator.SetTrigger("Attack");
        //https://forum.unity.com/threads/how-can-i-reference-to-a-component-of-another-gameobject.280451/
        Collider[] enemy = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);
        for (int i = 0; i < enemy.Length; i++)
        {
            Debug.Log("Hit: " + enemy);
        }
       */

