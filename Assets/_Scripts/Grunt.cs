using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grunt : MonoBehaviour, Ienemy
{
    public float currentHealth, power, toughness;
    public float maxHealth;

    public GameObject dmgEfect;

    void Start() {

        currentHealth = maxHealth;
        Debug.Log(currentHealth);
    }
    public void PerformAttack()
    {
        throw new System.NotImplementedException();
    }

    public void TakeDamaga(int amount)
    {
        currentHealth -= amount;
        Instantiate(dmgEfect, transform.position, Quaternion.identity);
        if(currentHealth <= 0)
        {
            Die();
        }
    }
    void Die() {
        Destroy(gameObject);
        
    }
}
