//Geschreven Door Djamali

using UnityEngine;
using System.Collections;

public class ManaPickup : MonoBehaviour {

	public PlayerMana mana;

	void OnTriggerEnter2D(Collider2D other)
	{
		//PlayerMana mana = (PlayerMana)manaBar.GetComponent("PlayerMana");

		if(other.transform.tag == "ManaPickup")
		{
			//mana.GetComponent<PlayerMana>().AdjustMana(Random.Range(8, 13));
			mana.AdjustMana(Random.Range(8, 13));
			Score.score += 150;
			Destroy(other.gameObject);
		}
	}
}