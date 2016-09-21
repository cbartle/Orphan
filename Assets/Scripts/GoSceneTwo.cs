using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoSceneTwo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionStay2D(Collision2D obj){

		if (obj.gameObject.name == "Bucky") {
			Debug.Log ("The Door");
			Debug.Log (Input.GetKeyUp ("e"));
			//Debug.Log (num);
			if(Input.GetKeyUp("e")){

				SceneManager.LoadScene ("WorldOneSceneTwo");
			}


			//Debug.Log (Conveyor.GetComponent<ConveyorMoving>().enabled);
		}

	}

	//void LoadScene("WorldOneSceneTwo"){
//
//	}

	// Update is called once per frame
	void Update () {
	
	

	}
}
