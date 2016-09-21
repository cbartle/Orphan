using UnityEngine;
using System.Collections;

public class ConveyorTouched : MonoBehaviour {


	float speed = 15f;
	//bool on = false;
	//Vector2 offset = new Vector2(0.0f, 0.0f);
	float velocity;


	void OnCollisionEnter(Collision obj){

		if (obj.gameObject.tag == "Conveyor")
			Debug.Log("Touching Conveyor");

		if (obj.gameObject.name == "Conveyor") {

			Debug.Log ("We touched it");

			float beltVelocity = speed * Time.deltaTime;
			gameObject.GetComponent<Rigidbody>().velocity = beltVelocity * transform.forward;
			//gameObject.GetComponent<ConveyorTouched> ().enabled = true;
		}

	}

	void OnCollisionStay(Collision obj){

	
		//on = true;
		if (obj.gameObject.name == "Conveyor"){

			Debug.Log ("The two objects are touching");

			float beltVelocity = speed * Time.deltaTime;
			gameObject.GetComponent<Rigidbody>().velocity = beltVelocity * transform.forward; 
			//gameObject.GetComponent<ConveyorTouched> ().enabled = true;
		}
//		else 
//			gameObject.GetComponent<ConveyorTouched> ().enabled = false;

	}

	void OnCollisionExit(Collision obj){

		//gameObject.GetComponent<ConveyorTouched> ().enabled = false;
	
	}


	// Use this for initialization
	void Start () {

		Debug.Log ("Hello there.  This log is working");
	

	}
	
	// Update is called once per frame
	void Update () {

		gameObject.GetComponent<Rigidbody>().velocity = (speed * Time.deltaTime) * transform.forward;
//		velocity = speed * Time.deltaTime;
//		gameObject.transform.Translate (velocity, 0.0f, 0.0f);
	}


	void FixedUpdate(){
		velocity = speed * Time.deltaTime;
		gameObject.transform.Translate (velocity, 0.0f, 0.0f);
	}
}
