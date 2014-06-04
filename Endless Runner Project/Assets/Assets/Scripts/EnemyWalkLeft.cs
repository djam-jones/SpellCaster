using UnityEngine;
using System.Collections;

public class EnemyWalkLeft : MonoBehaviour {
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		rigidbody2D.AddForce (new Vector2 (-2, 0));
	}
}
