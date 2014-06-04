using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {

	// Use this for initialization
	void Awake () 
	{
		Destroy (this, 1f);
	}
}
