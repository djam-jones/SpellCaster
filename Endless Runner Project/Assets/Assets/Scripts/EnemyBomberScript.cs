using UnityEngine;
using System.Collections;

public class EnemyBomberScript : MonoBehaviour {

	public float timer;
	public int bombTime;
	public GameObject Bomb;
	
	// Update is called once per frame
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
		var bomb = Instantiate (Bomb, this.transform.position, Quaternion.identity);
		Destroy (bomb, 3);
	}
}
