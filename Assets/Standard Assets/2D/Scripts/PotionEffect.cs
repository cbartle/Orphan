using UnityEngine;
using System.Collections;
using UnityStandardAssets._2D;

public class PotionEffect : MonoBehaviour {


	//public float getgravity = GameObject.Find("Bucky").GetComponent(CharcterController_Simple).GetComponent(gravity) = -15;
	//private float newspeed = 5.0f;
	//private float reversegravity;
	//private float Gravity;
	private Rigidbody2D m_Rigidbody2D;
	private Vector2 reversedVelocity;
	GameObject[] Boxes;

	// Use this for initialization
	void Start () {
		reversedVelocity.x = -1 * gameObject.GetComponent<Rigidbody2D> ().velocity.x;
		reversedVelocity.y = gameObject.GetComponent<Rigidbody2D> ().velocity.y;
		Boxes = GameObject.FindGameObjectsWithTag("FallingBox");

	}


	void OnEnable (){
		//GameObject.FindGameObjectWithTag ("FallingBox").
		gameObject.transform.Rotate (0, 0, 180);
		gameObject.GetComponent<Rigidbody2D> ().gravityScale *= -1;
		gameObject.GetComponent<PlatformerCharacter2D> ().m_JumpForce *= -1;
		//gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (reversedVelocity.x ,  reversedVelocity.y);
		//foreach (GameObject box in Boxes) {
		//	box.GetComponent<FallingBox> ().enabled = true;
		//}
		GameObject Box = GameObject.FindGameObjectWithTag("FallingBox");
	
	}

	// Update is called once per frame
	void Update () {
		



	}


	void OnDisable () {

		gameObject.transform.Rotate (0, 0, -180);
		gameObject.GetComponent<Rigidbody2D> ().gravityScale *= -1;
		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-1 * reversedVelocity.x, reversedVelocity.y);
		gameObject.GetComponent<PlatformerCharacter2D> ().m_JumpForce *= -1;
		/*foreach (GameObject box in Boxes) {
			box.GetComponent<FallingBox> ().enabled = false;
		}*/

	}
}
