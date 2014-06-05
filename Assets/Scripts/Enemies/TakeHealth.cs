using UnityEngine;
using System.Collections;

public class TakeHealth : MonoBehaviour {

	public PlayerHealth health;
		
	void Update()
	{
		if(health.currentHealth == 0)
		{
			Dead();
		}
	}
	
	void OnCollisionEnter2D (Collision2D other)
	{
		if(other.transform.tag == "Enemy")
		{
			health.ModifyHealth(-1);
			Destroy(other.gameObject);
		}
		else if(other.transform.tag == "Obstacle")
		{
			health.ModifyHealth(-1);
			Destroy(other.gameObject);
		}
	}

	void Dead()
	{
		//Application.LoadLevel(Application.loadedLevel);
		Application.LoadLevel("DeathScreen");
		/*Destroy(this.gameObject);
		Debug.Log("You Died and Suck Donkeyballs");*/
	}
}