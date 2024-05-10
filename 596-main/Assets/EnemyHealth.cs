using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // The current health of the player
    private float health;

    // The maximum health of the player
    public float maxHealth = 100;


    // Start is called before the first frame update
    void Start()
    {
        // Set the initial health to the maximum health
        health = maxHealth;
    }


    // Method to take damage
    public void TakeDamage()
    {
        // Reduce the health by the damage amount
        health -= 50;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
