using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerAttack : MonoBehaviour {

	public GameObject[] magic;
	//public ArrayList magic = new ArrayList();
	//public List<Object> magic = new List<Object>();

	public Transform spawnMagic;
	public GameObject manaBar;

	private Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
	}

	void Update () {
		anim.SetBool("Attack", false);

		/*if(Input.GetButtonDown("Up"))
		{
			Attack();
			anim.SetBool("Attack", true);
			foreach (GameObject sprite in magic)
			{
				sprite.transform.rigidbody2D.AddForce(Vector3.up * magicSpeed);
			}
		}

		if(Input.GetButtonDown("Left"))
		{
			Attack();
			anim.SetBool("Attack", true);
			foreach (GameObject sprite in magic)
			{
				sprite.transform.rigidbody2D.AddForce(Vector3.left * magicSpeed);
			}
		}

		if(Input.GetButtonDown("Right"))
		{
			Attack();
			anim.SetBool("Attack", true);
			foreach (GameObject sprite in magic)
			{
				sprite.transform.rigidbody2D.AddForce(Vector3.right * magicSpeed);
			}
		}*/

		if(Input.GetKeyDown(KeyCode.Return))
		{
			Attack();
		}
	}

	void Attack()
	{
		anim.SetBool("Attack", true);
		int magicIndex = Random.Range(0, magic.Length);
		/*sprite = */Instantiate(magic[magicIndex], spawnMagic.position, Quaternion.identity) /*as GameObject*/;
		//magic.Add(sprite);
		//GetComponent<PlayerMana>().AdjustMana(-4);

		PlayerMana mana = (PlayerMana)manaBar.GetComponent("PlayerMana");
		mana.AdjustMana(Random.Range(-5, -11));
	}
}
