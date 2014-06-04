using UnityEngine;
using System.Collections;

public class MagicController : MonoBehaviour {

	public float magicSpeed = 100f;
	private float destroyTime = 0.60f;
	
	void Start () {
		Destroy(this.gameObject, destroyTime);
	}

	void Update () {
		this.transform.rigidbody2D.AddForce(Vector3.right * magicSpeed);
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.transform.tag == "Enemy")
		{
			Destroy(other.gameObject);
			Destroy(this.gameObject);
		}
		else if(other.transform.tag != "Player")
		{
			Destroy(this.gameObject);
		}
	}
}
