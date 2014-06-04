using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

	public GameObject[] magic;
	public Transform spawnMagic;
	/*private float _dmg = 17;
	private bool attackHit = false;*/


	void Start () {

	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.E))
		{
			Attack();
		}
	}

	void Attack()
	{
		int magicIndex = Random.Range(0, magic.Length);
		Instantiate(magic[magicIndex], spawnMagic.position, spawnMagic.rotation);
	}
}
