﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	private bool hitWall = false;
	
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
	private bool canMove = true;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			if (canMove) {
			CharacterController controller = GetComponent<CharacterController>();
			if (controller.isGrounded) {
				moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
				moveDirection = transform.TransformDirection(moveDirection);
				moveDirection *= speed;
				if (Input.GetButton("Jump"))
					moveDirection.y = jumpSpeed;
				
			}
			moveDirection.y -= gravity * Time.deltaTime;
			controller.Move(moveDirection * Time.deltaTime);
			
			if (Input.GetMouseButton(0)) {
			 transform.LookAt(transform);
			 transform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X")*speed);
			}
		}
	}
	
	public void activateMovement() {
		canMove = true;
	}
	
	public void deactivateMovement() {
		canMove = false;
	}
}
