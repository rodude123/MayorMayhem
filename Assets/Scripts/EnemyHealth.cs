using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public int score;
    bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int amount/*, Vector3 hitPoint*/)
    {
        if (isDead)
        {
            return;
        }
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            isDead = true;
            Death();
            Destroy(gameObject);
        }
    }
    void Death()
    {
        FindObjectOfType<ScoreScript>().increment(score);
    }
  
}
