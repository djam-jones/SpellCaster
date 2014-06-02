using UnityEngine;
using System.Collections;

public class Score:MonoBehaviour {
	
	public static float score = 0;
	
	void Start(){
		score = 0;
	}

	void Update () {
		score += 1;
		guiText.text = "Score : " + score;
	}
}