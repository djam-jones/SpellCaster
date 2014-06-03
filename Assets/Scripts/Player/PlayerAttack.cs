using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

	public GameObject[] magic;
	public Transform spawnMagic;

	public PlayerMana mana;

	void Start () {
		//
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
		//mana.currentMana -= Random.Range(5, 15);
	}
}
