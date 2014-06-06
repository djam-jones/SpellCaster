//Geschreven Door Djamali

using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour {

	public PlayerHealth health;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.transform.tag == "HealthPickup")
		{
			health.ModifyHealth(1);
			Score.score += 150;
			Destroy(other.gameObject);
		}
	}
}
