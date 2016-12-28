using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class CameraSwitch : MonoBehaviour {
	
	public Camera playerCamera;
	public Camera consoleCamera;
	public GameObject Player;
	private MainConsole playerConsoleScript;
//	private PlayerMovement playerMovementScript;
	private FirstPersonController_ai playerMovementScript;

	// Use this for initialization
	void Start () {
		playerConsoleScript = playerCamera.GetComponent<MainConsole>();
		playerMovementScript = Player.GetComponent<FirstPersonController_ai>();
		ShowPlayerView();
	}
	
	// Update is called once per frame
	void Update () {
		 if (Input.GetMouseButtonDown (0)) {
			Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			 
			 if(Physics.Raycast (ray, out hit))
			 {
				  if(hit.transform.name == "TV")
				  {
					  ShowConsoleView();
				  }
				  else {        
					ShowPlayerView();
				  }
			 }
		 }
	}

	void ShowPlayerView() {
		consoleCamera.enabled = false;
		playerCamera.enabled = true;
		playerConsoleScript.deactivateConsole();
		playerMovementScript.activateMovement();
	}

	void ShowConsoleView() {
		consoleCamera.enabled = true;
		playerCamera.enabled = false;
		playerConsoleScript.activateConsole();
		playerMovementScript.deactivateMovement();
	}
	
}
