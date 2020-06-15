using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    //public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Debug.Log("Space PRessed");
        }
    }

    void Attack() {
        //animator.SetTrigger("Attack");
        //https://forum.unity.com/threads/how-can-i-reference-to-a-component-of-another-gameobject.280451/
       // CapsulleCollider[] = Physics.OverlapSphere(attackPoint, attackRange, enemyLayers);


    }
}
