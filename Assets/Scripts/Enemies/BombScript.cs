//Geschreven door Rishaad

using UnityEngine;
using System.Collections;

public class BombScript : MonoBehaviour {

	public GameObject explosionEffect;
	public float bombRadius = 2;
	public float timer = 1.5f;
	
	void Start()
	{
		Invoke("Explode", timer);
		Destroy(this.gameObject, 1.5f);
	}
	
	private void Explode()
	{
		//what is in range
		Collider[] cols = Physics.OverlapSphere(transform.position, bombRadius);
		
		//dmg possible enemies
		foreach(Collider col in cols)
		{
			if(col.transform.tag == "Player")
			{
				col.GetComponent<PlayerHealth>().ModifyHealth(-1);
			}
			Destroy(this.gameObject);
		}
		
		Instantiate(explosionEffect, transform.position, transform.rotation);
		Destroy(this.gameObject, 0f);
		
	}
}
