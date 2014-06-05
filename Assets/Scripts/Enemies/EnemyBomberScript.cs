using UnityEngine;
using System.Collections;

public class EnemyBomberScript : MonoBehaviour {

	public float timer;
	public float bombTime;
	public GameObject Bomb;
	public Transform bombSpawnPoint;

	void FixedUpdate ()
	{
		timer += Time.deltaTime;
		if (timer > bombTime) 
		{
			dropBomb();
			timer = 0;
		}
	}

	void dropBomb()
	{
		Instantiate(Bomb, bombSpawnPoint.position, Quaternion.identity);
	}
}
