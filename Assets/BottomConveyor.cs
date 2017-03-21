using UnityEngine;
using System.Collections;

public class BottomConveyor : MonoBehaviour {

	public float speed = 0.5f;



	void OnTriggerStay2D(Collider2D obj){

		//reacts if the script is on so that we can turn off and on the conveyor effect
		if (gameObject.GetComponent<BottomConveyor> ().enabled) {
			GameObject player = GameObject.FindGameObjectWithTag ("Player");
			if (!player.gameObject.GetComponent<PotionEffect> ().enabled) {
				obj.gameObject.transform.Translate (-speed, 0.0f, 0.0f);
			} else
				obj.gameObject.transform.Translate (speed, 0.0f, 0.0f);
		}

	}



	// Use this for initialization
	void Start () {


	}

}
