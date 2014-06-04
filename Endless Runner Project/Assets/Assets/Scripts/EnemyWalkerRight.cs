using UnityEngine;
using System.Collections;

public class EnemyWalkerRight : MonoBehaviour {
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		rigidbody2D.AddForce (new Vector2 (4, 0));
	}
}
