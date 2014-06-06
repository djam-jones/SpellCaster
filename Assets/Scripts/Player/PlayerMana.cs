//Geschreven Door Djamali

using UnityEngine;
using System.Collections;

public class PlayerMana : MonoBehaviour {

	public float maxMana = 100f;
	public float currentMana;
	public GUIStyle manaBar;

	public float manaBarWidth;
	private float manaBarHeight = 24;


	void Awake() {
		currentMana = maxMana;
		manaBarWidth = 137.5f;
	}

	void OnGUI()
	{
		//GUI.DrawTexture(new Rect(63, 87, manaBarWidth, manaBarHeight), manaBar);
		GUI.Box(new Rect(63, 87, manaBarWidth, manaBarHeight),  /*currentMana + ":" + maxMana*/ "", manaBar);
	}

	void Update() {
		AdjustMana(0);
		if(currentMana <= 3)
		{
			currentMana = 20;
		}
	}

	public void AdjustMana(int adj)
	{
		currentMana +=adj;
		manaBarWidth = 137.5f * (currentMana / (float)maxMana);
		if(currentMana < 0)
		{
			currentMana = 0;
		}
		if(currentMana > maxMana)
		{
			currentMana = maxMana;
		}
		if(maxMana < 1)
		{
			maxMana = 1;
		}
	}

	void OnTrigger2DEnter(Collider2D other)
	{
		if(currentMana < 100f)
		{
			if(other.transform.tag == "ManaPickup")
			{
				AdjustMana(Random.Range(8, 13));
			}
		}
	}
}
