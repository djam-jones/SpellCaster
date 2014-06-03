using UnityEngine;
using System.Collections;

public class EndScreen : MonoBehaviour {

	public Texture backgroundTexture;
	//button placement kan ook worden aangemaakt voor de x positie. 
	public float buttonPlacementY; // voor de tweede button. 
	public float buttonPlacementY2; // voor de derde button
	public float buttonPlacementY3; // voor de vierde button

	void OnGUI(){
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);

		if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * .5f, Screen.width * .5f, Screen.height * .1f), "Retry"))
		{
			Application.LoadLevel(1);
		}

		if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * buttonPlacementY2, Screen.width * .5f, Screen.height * .1f), "Back to Menu"))
		{
			Application.LoadLevel(0);
		}
		
		if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * buttonPlacementY3, Screen.width * .5f, Screen.height * .1f), "Quit"))
		{
			Application.Quit();
		}
	}
}