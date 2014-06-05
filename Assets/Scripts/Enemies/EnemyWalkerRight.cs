using UnityEngine;
using System.Collections;

public class EnemyWalkerRight : MonoBehaviour {
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		rigidbody2D.AddForce (new Vector2 (5.5f, 0f));
	}
}
