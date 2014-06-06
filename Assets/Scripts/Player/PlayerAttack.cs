//Geschreven Door Djamali

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerAttack : MonoBehaviour {

	public GameObject[] magic;

	public Transform spawnMagic;
	public GameObject manaBar;

	private Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
	}

	void Update () {
		anim.SetBool("Attack", false);

		if(Input.GetKeyDown(KeyCode.Return))
		{
			Attack();
		}
	}

	void Attack()
	{
		anim.SetBool("Attack", true);
		int magicIndex = Random.Range(0, magic.Length);
		Instantiate(magic[magicIndex], spawnMagic.position, Quaternion.identity);

		PlayerMana mana = (PlayerMana)manaBar.GetComponent("PlayerMana");
		mana.AdjustMana(Random.Range(-5, -11));
	}
}
