//Geschreven door Rishaad en Djamali

using UnityEngine;
using System.Collections;
//Main menu code. 

public class mainMenu : MonoBehaviour 
{
	public Texture backgroundTexture;
	//button placement kan ook worden aangemaakt voor de x positie 
	public float buttonPlacementY; // voor de tweede button 
	public float buttonPlacementY2; // voor de derde button
	public float buttonPlacementY3; // voor de vierde button
	public GUIStyle startButton;

	void OnGUI()
	{
		//laat de background texture zien. 
		GUI.DrawTexture(new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);

		//laat de buttons zien. Met de functie om de game scene in te laden.
		if (GUI.Button(new Rect(Screen.width/2f, Screen.height/1.3f, 244, 134), "", startButton))
		{
			Application.LoadLevel(1);
		}

		/*if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * buttonPlacementY, Screen.width * .5f, Screen.height * .1f), "Instructions"))
		{
			
		}

		if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * buttonPlacementY2, Screen.width * .5f, Screen.height * .1f), "Credits"))
		{
			
		}

		if (GUI.Button(new Rect(Screen.width * .25f, Screen.height * buttonPlacementY3, Screen.width * .5f, Screen.height * .1f), "Quit"))
		{
			Application.Quit();
		}*/


	} 

}
