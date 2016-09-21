using UnityEngine;
using System.Collections;

public class CharcterController_Simple : MonoBehaviour {

	public float speed = 5.0f;
	public float jumpSpeed = 18.0f;
	public float gravity = 150.0f;

	private Vector3	moveDirection = Vector3.zero;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		CharacterController controller = GetComponent<CharacterController> ();
		if (controller.isGrounded) {	
			moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, 0);
			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection *= speed;


			if (Input.GetButton ("Jump")) {
					moveDirection.y = jumpSpeed;
				}

		}

		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);
	}
}
