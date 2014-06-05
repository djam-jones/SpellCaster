using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour {

	public PlayerHealth health;

	void OnTrigger2DEnter(Collider2D other)
	{
		if(other.transform.tag == "Player")
		{
			health.ModifyHealth(1);
			Destroy(other.gameObject);
			Score.score += 150;
		}
	}
}
