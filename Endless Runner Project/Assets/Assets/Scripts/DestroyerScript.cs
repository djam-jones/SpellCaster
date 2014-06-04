using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D other)
	{
		if(other.transform.tag != "Player")
		{
			Destroy(other.gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.transform.tag != "Player")
		{
			Destroy(other.gameObject);
		}
	}

}