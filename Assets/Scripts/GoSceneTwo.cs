using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoSceneTwo : MonoBehaviour {

	//private int numScenes;
	private int buildIndex = 0;
	//Scene activeScene = SceneManager.GetActiveScene();
	//private bool KeyPress;
	// Use this for initialization
	void Start () {

	}

	int num = 0;
	void OnTriggerStay2D(Collider2D obj){

		if (obj.gameObject.GetComponent<hasKeys>().enabled) {

			if (Input.GetKeyDown ("e")) {
				
				num++;
				if (num == 1) {
					buildIndex = SceneManager.GetActiveScene().buildIndex;
					buildIndex += num;
					Debug.Log ("The current BuildIndex: " + buildIndex);
					SceneManager.LoadScene (buildIndex);
				}
				//
			}

			if (Input.GetKeyUp ("e"))
				Debug.Log ("THe number of times num was counted was: " + num);
				num = 0;

		} else {

			gameObject.GetComponent<doorGUI> ().enabled = true;
		}

	}

	void OnTriggerExit2D(Collider2D obj){

		gameObject.GetComponent<doorGUI> ().enabled = false;

	}

	// Update is called once per frame
	void Update () {

	}

}
