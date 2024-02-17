using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	public GameObject enemy;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject boss;

    void Start()
	{
		InvokeRepeating("SpawnEnemies",0,35);
	}

	void SpawnEnemies()
	{
		for(int i = 0; i < 25; i++)
			{
				Instantiate(enemy, new Vector2(Random.Range(-46,20), Random.Range(-40, 5)), Quaternion.identity);
			}

			for(int i = 0; i < 7; i++)
			{
				Instantiate(enemy2, new Vector2(Random.Range(-19,20), Random.Range(-21, 5)), Quaternion.identity);
			}

			for(int i = 0; i < 4; i++)
			{
				Instantiate(enemy3, new Vector2(Random.Range(-19,20), Random.Range(-21, 5)), Quaternion.identity);
			}

			for(int i = 0; i < 1; i++)
			{
				Instantiate(boss, new Vector2(Random.Range(-19,20), Random.Range(-25, -40)), Quaternion.identity);
			}
		}
}
