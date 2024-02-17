using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    EnemyHealth enemyHealth;
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
            enemyHealth.TakeDamage(20);
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag != "Enemy")
        {
            Destroy(gameObject, 5);
        }
    }

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Enemy")
        {
            enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
            enemyHealth.TakeDamage(20);
            Destroy(gameObject);
        }
		else if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag != "Enemy")
        {
            Destroy(gameObject, 5);
        }
	}
}
