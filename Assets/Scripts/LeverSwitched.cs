using UnityEngine;
using System.Collections;

public class LeverSwitched : MonoBehaviour {
	
	GameObject[] Conveyor;
	GameObject[] ConveyorBottom;
	//Vector3 rotate = (0.0, 0.0, 0.0);
	// Use this for initialization
	void Start () {
	
		Conveyor = GameObject.FindGameObjectsWithTag ("Conveyor");
		ConveyorBottom = GameObject.FindGameObjectsWithTag ("ConveyorBottom");

	}

	void OnTriggerStay2D(Collider2D obj){

		if (obj.gameObject.name == "Bucky") {
			//turns on the Script to allow for the switching of the levers
			if(!gameObject.GetComponent<LeverSwitched>().enabled){
				gameObject.GetComponent<LeverSwitched> ().enabled = true;
			}

		}

	}

	void OnTriggerExit2D(Collider2D obj){

		gameObject.GetComponent<LeverSwitched> ().enabled = false;

	}


	// Update is called once per frame
	void Update () {
		//if 'e' is pressed
		if(Input.GetKeyUp ("e")){
			//Debug.Log("The action key has been pressed while collision is happening");

			foreach (GameObject convey in Conveyor) {
				//turn off the conveyor action of each object with the tag "Conveyor"
				if (convey.GetComponent<ConveyorMoving> ().enabled == true){
					convey.GetComponent<ConveyorMoving> ().enabled = false;
					//
					GameObject.Find("Lever").GetComponent<Renderer>().enabled = false;
					GameObject.Find("LeverOpposite").GetComponent<Renderer>().enabled = true;
				}
				//if effect is already off, turn it back on
				else{
					convey.GetComponent<ConveyorMoving> ().enabled = true;
					//convey.GetComponent<BottomConveyor> ().enabled = true;
					GameObject.Find("LeverOpposite").GetComponent<Renderer>().enabled = false;
					GameObject.Find("Lever").GetComponent<Renderer>().enabled = true;
				}
			}
			foreach (GameObject bottomConveyor in ConveyorBottom) {
			
				if (bottomConveyor.GetComponent<BottomConveyor> ().enabled == true) {
					bottomConveyor.GetComponent<BottomConveyor> ().enabled = false;
				}else 
					bottomConveyor.GetComponent<BottomConveyor> ().enabled = true;
			
			}
		}
	}
}
