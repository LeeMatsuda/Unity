using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningDoor : MonoBehaviour {
	public GameObject OpenedDoor;
	public GameObject ClosedDoor;
	public DoorTrigger Trigger;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E)) {
			if (Trigger.isInTrigger) { 
				OpenedDoor.SetActive (!OpenedDoor.activeSelf);
				ClosedDoor.SetActive (!OpenedDoor.activeSelf);
			}
		}


		
	}
}
