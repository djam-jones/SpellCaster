using UnityEngine;
using System.Collections;

public class SpawnObstacles : MonoBehaviour {

	private bool spawning = false;
	public float obsTimer = 4.0f;
	public float randomSpawn;

	public GameObject[] obstacles;
	public Transform spawnObs;

	void Update()
	{
		if(spawning)
		{
			obsTimer += Time.deltaTime;
		}

		if(randomSpawn <= obsTimer)
		{
			Spawn();
		}
		randomSpawn = Random.Range(0, 3000);
	}

	void Spawn()
	{
		int obstacleIndex = Random.Range(0, obstacles.Length);
		spawning = true;
		Instantiate(obstacles[obstacleIndex], spawnObs.position, spawnObs.rotation);
		obsTimer = 0f;
	}

	void OnColliderEnter2D (Collision2D other)
	{
		if(other.transform.tag == "Player")
		{
			Destroy(other.gameObject);
		}
	}
}