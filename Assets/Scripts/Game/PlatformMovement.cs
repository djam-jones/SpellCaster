using UnityEngine;
using System.Collections;

public class PlatformMovement : MonoBehaviour {

	public float movementSpeed = 15;
	public Vector2 direction = Vector3.left;

	void Start () {
		//
	}

	void Update () {
		Move();
	}

	void Move()
	{
		transform.Translate(direction * movementSpeed * Time.deltaTime);
	}
}
