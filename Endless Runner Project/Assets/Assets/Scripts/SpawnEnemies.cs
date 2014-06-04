using UnityEngine;
using System.Collections;

public class SpawnEnemies:MonoBehaviour {

	public GameObject[] enemies;
	public Transform[] spawns;
	public GameObject player;
	
	public float timer = 0f;

	private float spawnTime = 3f;

	private GameObject targetEnemy;
	private Vector3 targetPos;

	void FixedUpdate()
	{
		timer += Time.deltaTime;
		if (timer > spawnTime) 
		{
			Spawn();
			timer = 0;
			spawnTime = Random.Range (2, 4);
		}
	}

	void Spawn()
	{
		int enemyToSpawn = Random.Range (0, 3);

		switch (enemyToSpawn) 
		{
			case 0:
				targetEnemy = enemies[0];
				int rY = Random.Range(10, 20);
				targetPos = new Vector3(10, rY, 0);
				break;
			case 1:
				targetEnemy = enemies[1];
				int rX = Random.Range(10,20);
				targetPos = new Vector3(rX, 1, 0);
				break;
			default:
				targetEnemy = enemies[2];
				int rX3 = Random.Range(0,-10);
				targetPos = new Vector3(rX3, 1, 0);
				break;	
		}
		Instantiate (targetEnemy, targetPos, Quaternion.identity);

	}
}