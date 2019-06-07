using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {
	public bool isInTrigger = false;
	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
			isInTrigger = true;
		}
	}
	void OnTriggerExit(Collider col){
		if (col.tag == "Player") {
			isInTrigger = false;
		}


	}

}
