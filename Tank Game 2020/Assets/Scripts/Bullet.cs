using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;
    public float bulletSpeed;
    public float destroyDelay;
    public Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        // Adds force for the bullet object
       rigidBody.AddForce(transform.forward * bulletSpeed);
       // Destroys the game object after the timer expire
       Destroy(gameObject,destroyDelay);
    }

    void OnCollisionEnter(Collision colli)
    {
        // If the bullet hits the ground or the wall it is destroyed
        if (colli.collider.CompareTag("Ground") || colli.collider.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

        //if the bullet hits the enemy
        if (colli.collider.CompareTag("Enemy"))
        {
            // Getting the health component of the enemy
            Health enemyHealth = colli.collider.gameObject.GetComponent<Health>();
            // Enemy takes damage
            enemyHealth.takeDamage(damage);
        }
    }

}
