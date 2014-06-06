//Geschreven door Rishaad

using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

	private Transform target;
	private float attackDelay;
	private float speed = 5f;

	public float attackCooldown = 4f;
	//public int doDMG = 1;
	public PlayerHealth health;

	void Update() 
	{
		if(target)
		{
			Vector2 rayCastDirection = target.position - transform.position;
			Ray ray = new Ray(transform.position, rayCastDirection);
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit))
			{
				if(hit.transform.tag == "Player")
				{
					transform.LookAt(target);
					transform.Translate(Vector3.left * speed * Time.deltaTime);

					if(Vector3.Distance(this.transform.position, target.position) < 2)
					{
						if(Time.time > attackDelay)
						{
							Attack();
						}
					}
				}
			}
		}
	}
	void Attack()
	{
		attackDelay = Time.deltaTime + attackCooldown;
		//health.ModifyHealth(-1);
		//target.GetComponent<PlayerHealth>().ModifyHealth(doDMG);
		Debug.Log("GET OVER HERE!!");
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.tag == "Player")
		{
			target = other.transform;
		}
	}
	void OnTargetExit2D (Collider2D other)
	{
		if(other.tag == "Player")
		{
			target = null;
		}
	}
}
