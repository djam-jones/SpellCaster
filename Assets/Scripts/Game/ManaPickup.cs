using UnityEngine;
using System.Collections;

public class ManaPickup : MonoBehaviour {
	
	public PlayerMana mana;

	void OnTrigger2DEnter(Collider2D other)
	{
		if(other.transform.tag == "Player")
		{
			mana.AdjustMana(Random.Range(8, 13));
			Destroy(other.gameObject);
			Score.score += 150;
		}
	}
}