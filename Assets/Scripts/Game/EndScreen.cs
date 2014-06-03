using UnityEngine;
using System.Collections;

public class EndScreen : MonoBehaviour {

	string gameScene = "EndlessRunnerProject";

	void OnGUI(){
		if(GUI.Button(new Rect(Screen.width/1.5f, Screen.height/4f ,100,25), "Retry")){
			Application.LoadLevel(gameScene);
		}
		if(GUI.Button(new Rect(Screen.width/1.5f, Screen.height/3f ,100,25), "Quit")){
			Application.Quit();
		}
	}
}