﻿using UnityEngine;
using System.Collections;

public class PlayerPhysicsMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per physics frame
	void FixedUpdate () {
		// reset velocity every frame
		GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);

		// press W to applu upward force
		if ( Input.GetKey(KeyCode.W) ) {
			GetComponent<Rigidbody2D>().velocity += new Vector2( 0f, 100f ) * Time.deltaTime;
		}

		if ( Input.GetKey(KeyCode.S) ) {
			GetComponent<Rigidbody2D>().velocity += new Vector2( 0f, -100f ) * Time.deltaTime;
		}

		if ( Input.GetKey(KeyCode.A) ) {
			GetComponent<Rigidbody2D>().velocity += new Vector2( -100f, 0f ) * Time.deltaTime;
		}

		if ( Input.GetKey(KeyCode.D) ) {
			GetComponent<Rigidbody2D>().velocity += new Vector2( 100f, 0f ) * Time.deltaTime;
		}
	}
}
