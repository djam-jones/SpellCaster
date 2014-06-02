using UnityEngine;
using System.Collections;

public class KillPlayers : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D other)
	{
		if(other.transform.tag == "Player")
		{
			Debug.Log("DOOD");
			Application.LoadLevel(Application.loadedLevel);
		}
	}

}
