using UnityEngine;
using System.Collections;

public class TakeHealth : MonoBehaviour {

	public PlayerHealth health;
	private int Enemies;

	void Start()
	{
		Enemies = GameObject.FindGameObjectsWithTag("Enemy").Length;

		Debug.Log(Enemies);
	}

	void Update()
	{
		if(health.currentHealth == 0)
		{
			Dead();
		}
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.transform.tag == "Enemy")
		{
			health.ModifyHealth(-1);
			//Destroy(other.gameObject);
			Debug.Log("Taking Damage");
		}
	}

	void Dead()
	{
		Destroy(this.gameObject);
		Debug.Log("You Died and Suck Donkeyballs");
	}
}