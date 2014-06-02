using UnityEngine;
using System.Collections;

public class FadeScreen : MonoBehaviour {

	void Update()
	{
		renderer.material.color -= new Color(0, 0, 0, 0.03f);
	}
}