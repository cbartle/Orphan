using UnityEngine;
using System.Collections;

public class LeverSwitched : MonoBehaviour {
	
	GameObject[] Conveyor;
	//Vector3 rotate = (0.0, 0.0, 0.0);
	// Use this for initialization
	void Start () {
	
		Conveyor = GameObject.FindGameObjectsWithTag ("Conveyor");

	}

	void OnCollisionStay2D(Collision2D obj){

		if (obj.gameObject.name == "Bucky") {
			//Debug.Log ("We are colliding with the object");
			//Debug.Log (Input.GetKeyUp ("e"));
			//Debug.Log (num);
			if(!gameObject.GetComponent<LeverSwitched>().enabled){

				gameObject.GetComponent<LeverSwitched> ().enabled = true;
			}


			//Debug.Log (Conveyor.GetComponent<ConveyorMoving>().enabled);
		}

	}

	void OnCollisionExit2D(Collision2D obj){

		gameObject.GetComponent<LeverSwitched> ().enabled = false;

	}


	// Update is called once per frame
	void Update () {

		if(Input.GetKeyUp ("e")){
			//Debug.Log("The action key has been pressed while collision is happening");

			foreach (GameObject convey in Conveyor) {

				if (convey.GetComponent<ConveyorMoving> ().enabled == true){
					convey.GetComponent<ConveyorMoving> ().enabled = false;
					GameObject.Find("Lever").GetComponent<Renderer>().enabled = false;
					GameObject.Find("LeverOpposite").GetComponent<Renderer>().enabled = true;
				}
				else{
					convey.GetComponent<ConveyorMoving> ().enabled = true;
					GameObject.Find("LeverOpposite").GetComponent<Renderer>().enabled = false;
					GameObject.Find("Lever").GetComponent<Renderer>().enabled = true;
				}
			}
		}
	}
}
