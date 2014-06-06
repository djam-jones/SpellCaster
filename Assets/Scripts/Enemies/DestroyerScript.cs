//Geschreven door Djamali

using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D other)
	{
		if(other.transform.tag != "null")
		{
			Destroy(other.gameObject);
		}
		if(other.transform.tag == "Player")
		{
			Application.LoadLevel(Application.loadedLevel);
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