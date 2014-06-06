//Geschreven Door Djamali

using UnityEngine;
using System.Collections;

public class SpawnPickups : MonoBehaviour {

	public GameObject[] pickUps;
	public Transform[] allSpawns;

	private bool spawning = false;
	public float timer = 5.0f;
	public float randomSpawn;

	void Update() 
	{
		if(spawning)
		{
			timer += Time.deltaTime;
		}

		if(randomSpawn <= timer)
		{
			Spawn();
		}
		randomSpawn = Random.Range(0, 2225);
	}

	void Spawn()
	{
		spawning = true;
		int pickupIndex = Random.Range(0, pickUps.Length);
		int spawnIndex = Random.Range(0, allSpawns.Length);
		Instantiate(pickUps[pickupIndex], allSpawns[spawnIndex].position, Quaternion.identity);
		timer = 0.0f;
	}
}
