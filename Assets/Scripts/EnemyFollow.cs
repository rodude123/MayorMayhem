using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;
    public float distance;
    public int health = 100;
    private Transform target;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
		if(target != null)
		{
			Vector3 direction = target.position - transform.position;

			if (direction.magnitude > 0.1f)
			{
				if (Vector3.Dot(Vector3.right, direction) > 0)
					transform.rotation = Quaternion.LookRotation(direction) * Quaternion.Euler(0, -90, 0);
				else
					transform.rotation = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 90, 180);
			}
			if (Vector2.Distance(transform.position, target.position) < 15 && Vector2.Distance(transform.position, target.position) > distance)
			{
				transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
		}
        
        }


		
        //transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //comment
    }
}
