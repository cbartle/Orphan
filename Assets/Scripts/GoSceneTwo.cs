using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoSceneTwo : MonoBehaviour {


	// Use this for initialization
	void Start () {


	}

	void OnTriggerStay2D(Collider2D obj){

		if (obj.gameObject.GetComponent<hasKeys>().enabled) {
			
			if(Input.GetKeyUp("e"))

				SceneManager.LoadScene ("WorldOneSceneTwo");
		} else {

			gameObject.GetComponent<GoSceneTwo> ().enabled = true;
		}

	}

	void OnTriggerExit2D(Collider2D obj){

		gameObject.GetComponent<GoSceneTwo> ().enabled = false;

	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI(){
		GUI.color = Color.blue;
		GUI.Label (new Rect (50, 100, 300, 50), "Two keys are required to pass through this door");

	}
}
