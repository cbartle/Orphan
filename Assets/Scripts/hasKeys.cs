using UnityEngine;
using System.Collections;

public class hasKeys : MonoBehaviour {

	private GameObject silverKey;
	private GameObject goldKey;


	// Use this for initialization
	void Awake () {
	
		silverKey = GameObject.Find ("key_silver");
		goldKey = GameObject.Find ("key_gold");

	}

	//used when touching keys
	void OnCollisionStay2D(Collision2D obj){

		//if we are touching the silver key
		if (obj.gameObject == silverKey) {

			Debug.Log ("We are touching the key");
			//make the gold key appear
			if (Input.GetKeyUp ("e")) {

				goldKey.GetComponent<Renderer> ().enabled = true;
				goldKey.GetComponent<BoxCollider2D> ().enabled = true;
				silverKey.GetComponent<Renderer> ().enabled = false;
				silverKey.GetComponent<BoxCollider2D> ().enabled = false;
			}

		}

		if (obj.gameObject == goldKey) {

			Debug.Log ("We are touching the key");
			//make the gold key appear
			if (Input.GetKeyUp ("e")) {

				goldKey.GetComponent<Renderer> ().enabled = false;
				goldKey.GetComponent<BoxCollider2D> ().enabled = false;
				gameObject.GetComponent<hasKeys> ().enabled = true;
			}

		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}