using UnityEngine;
using System.Collections;

public class CrouchingGUI : MonoBehaviour {




	// Use this for initialization
	void Start () {

		gameObject.GetComponent<CrouchingGUI> ().enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerStay2D(Collider2D obj){

		//turns on the script making the GUI appear
		gameObject.GetComponent<CrouchingGUI> ().enabled = true;

	
	}

	void OnTriggerExit2D(Collider2D obj){

		//turns of the script making the instructions disappear
		gameObject.GetComponent<CrouchingGUI> ().enabled = false;


	}

	void OnGUI(){
		GUI.color = Color.blue;
		GUI.Label (new Rect (50, 100, 300, 50), "Sometimes you need to go below objects.  To crouch, press left control");

	}
		
}
