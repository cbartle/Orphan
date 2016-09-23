using UnityEngine;
using System.Collections;

public class CrouchingGUI : MonoBehaviour {

	private GameObject Bucky;


	// Use this for initialization
	void Start () {

		Bucky = GameObject.Find ("Bucky");

		gameObject.GetComponent<CrouchingGUI> ().enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerStay2D(Collider2D obj){

		//if (obj.gameObject == Bucky) {
			Debug.Log ("Bucky is here");
			gameObject.GetComponent<CrouchingGUI> ().enabled = true;
		//}
	
	}

	void OnTriggerExit2D(Collider2D obj){

		//if (obj.gameObject == Bucky) {
			gameObject.GetComponent<CrouchingGUI> ().enabled = false;
		//}

	}

	void OnGUI(){
		GUI.color = Color.blue;
		GUI.Label (new Rect (50, 100, 300, 50), "Sometimes you need to go below objects.  To crouch, press left control");


	}
		
}
