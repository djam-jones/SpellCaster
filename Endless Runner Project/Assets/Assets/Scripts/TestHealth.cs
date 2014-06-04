using UnityEngine;
using System.Collections;

public class TestHealth : MonoBehaviour {

	public PlayerHealth health;

	void OnGUI()
	{
		if(GUI.Button( new Rect(Screen.width/1.5f, Screen.height/4 * Screen.width/10 * 0,100,25), "Add Health")){
			health.AddHearts(1);
		}
		if(GUI.Button( new Rect(Screen.width/2f, Screen.height/4 * Screen.width/10 * 0,100,25), "Take Damage")){
			health.ModifyHealth(-1);
		}
		if(GUI.Button( new Rect(Screen.width/3f, Screen.height/4 * Screen.width/10 * 0,100,25), "Heal Up")){
			health.ModifyHealth(1);
		}
	}
}
