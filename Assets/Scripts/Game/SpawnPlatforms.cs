//Geschreven door Djamali

using UnityEngine;
using System.Collections;

public class SpawnPlatforms : MonoBehaviour {

	private float spawnTimer = 4.0f;
	private bool spawning = false;

	public GameObject platforms;
	public Transform spawnPlats;

	void Update()
	{
		if(spawning)
		{
			spawnTimer += Time.deltaTime;
		}

		if (spawnTimer >= 2)
		{
			Spawn();
		}
	}

	void Spawn()
	{
		spawning = true;
		Instantiate(platforms, spawnPlats.position, spawnPlats.rotation);
		spawnTimer = 0f;
	}
}