using UnityEngine;
using System.Collections;

public class doorGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){

		GUI.color = Color.blue;

		GUI.Label (new Rect (50, 100, 300, 50), "Two keys are required to pass through this door");

	}
}
