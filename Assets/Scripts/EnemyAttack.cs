using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    public float timeBetweenAttack = 0.5f;
    public int damage = 10;
	public double distanceAttack = 1.2;
    GameObject player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    //int playerHealth = 100;
    //int enemyHealth = 100;
    bool playerInRange;
    float timer;
    private Transform target;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
    }

    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Vector2.Distance(transform.position, target.position) > distanceAttack)
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (Vector2.Distance(transform.position, target.position) < distanceAttack)
        {
            playerInRange = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Vector2.Distance(transform.position, target.position));
        if (Vector2.Distance(transform.position, target.position) < distanceAttack)
        {
            playerInRange = true;
        
        }
        else
        {
            playerInRange = false;
        }

        timer += Time.deltaTime;
        if (timer >= timeBetweenAttack && playerInRange && enemyHealth.currentHealth > 0)
        {
            Attack();
        }
        //if (timer >= timeBetweenAttack && playerInRange && enemyHealth > 0)
        //{
            //Attack();
        //}
        
    }

    void Attack()
    {
        timer = 0f;

        if (playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage(damage);
        }
        //if (playerHealth > 0)
        //{
        //    playerHealth = -damage;
        //}
    }
}
