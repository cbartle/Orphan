using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour {

	GameObject silverKey;
	GameObject goldKey;
	GameObject Bucky;

	void Awake(){
		silverKey = GameObject.Find ("key_silver");
		goldKey = GameObject.Find ("key_silver");
		Bucky = GameObject.Find ("Bucky");
	}
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay2D(Collision2D obj){

		if (obj.gameObject.tag.Equals ("FallingBox") || obj.gameObject.tag.Equals ("StickyBox")) {
			if (!goldKey.GetComponent<Renderer> ().enabled && !Bucky.GetComponent<hasKeys>().enabled) {
				silverKey.GetComponent<Renderer> ().enabled = true;
				silverKey.GetComponent<BoxCollider2D> ().enabled = true;
			}

		}
	}
}
