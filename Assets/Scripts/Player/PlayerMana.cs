using UnityEngine;
using System.Collections;

public class PlayerMana : MonoBehaviour {

	/*public float maxMana = 100f;
	public float currentMana;
	//public GUITexture manaBar;
	private float manaBarLength;
	private float percentOfMana;

	public Texture2D manaBarTexture;

	void Awake() {
		currentMana = maxMana;
		//manaBar = GameObject.FindGameObjectWithTag("PlayerManaBar").GetComponent<GUITexture>();
	}

	void OnGUI()
	{
		if(currentMana > 0)
		{
			GUI.DrawTexture((Screen.width/4) - 100, 20, manaBarLength, 20); //manaBarTexture;
		}
	}

	void Update() {

		percentOfMana = currentMana/maxMana;
		manaBarLength = percentOfMana * 100;


		if(currentMana < 20)
		{
			currentMana = 20;
		}
	}

	void OnCollision2DEnter(Collision2D other)
	{
		if(currentMana < 100f)
		{
			if(other.transform.tag == "Pickup")
			{
				currentMana += Random.Range(5, 15);
			}
		}
	}*/
}
