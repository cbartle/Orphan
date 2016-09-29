using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {
	int timesPressed = 0;
	int num = 0;

	void OnTriggerStay2D(Collider2D obj){

		//GetComponent<TestScript> ().enabled = true;
		if (Input.GetKeyDown("e")) {
			num++;
			//Update ();
			if (num == 1) {
				timesPressed += num;
				Debug.Log ("the key was pressed once but has been documented " + timesPressed + " times");
			}
		}

		if (Input.GetKeyUp ("e")) {

			num = 0;
		}
	}
}
