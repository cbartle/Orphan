using UnityEngine;
using System.Collections;

public class ConveyorMoving : MonoBehaviour {

	//float speed = 1f;
	public float velocity = 0.5f;



	void OnCollisionStay2D(Collision2D obj){

		//when colliding with the player		
		//if (obj.gameObject.name == "Bucky") {

			Debug.Log ("We are touching the conveyor");
			//reacts if the script is on so that we can turn off and on the conveyor effect
			if (gameObject.GetComponent<ConveyorMoving> ().enabled)
				
				obj.gameObject.transform.Translate (velocity, 0.0f, 0.0f);

		//}

	}



	// Use this for initialization
	void Start () {


	}

}
