//Geschreven door Djamali

using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0f, 0f, 32.5f) * Time.deltaTime);
	}
}
