﻿using UnityEngine;
using System.Collections;

public class moveplayersprite : MonoBehaviour {
	SpriteRenderer player;
	public float speed = .4f;


	// Use this for initialization
	void Start () {
		player = GetComponent<SpriteRenderer>();

	}

	// Update is called once per frame
	void Update () {
		transform.eulerAngles = Vector3.zero;
		GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		if(Input.GetKey(KeyCode.A)){
			GetComponent<Rigidbody2D> ().velocity += Vector2.left*speed;
			//transform.position += Vector3.left * speed;
			//transform.localScale=new Vector3(-1,1,1);
			//transform.eulerAngles = Vector3.forward * 270;

		}
		if (Input.GetKeyDown (KeyCode.A)) {
			//rotation.eulerAngles= Vector3.forward * 90f;
			//transform.rotation = rotation;
			//transform.localScale.Set(-1f*transform.localScale.x,-1f*transform.localScale.y,-1f*transform.localScale.z);

		}
		if(Input.GetKey(KeyCode.D)){
			GetComponent<Rigidbody2D> ().velocity += Vector2.right*speed;
			//transform.position+=Vector3.right * speed;
			//transform.eulerAngles = Vector3.forward * 90;


		}
		if (Input.GetKeyDown (KeyCode.D)) {
			//rotation.eulerAngles= Vector3.forward * 90f;
			//transform.rotation = rotation;
			//transform.localScale.Set(-1f*transform.localScale.x,-1f*transform.localScale.y,-1f*transform.localScale.z);

		}
		if(Input.GetKey(KeyCode.W)){
			GetComponent<Rigidbody2D> ().velocity += Vector2.up*speed;
			//transform.position+=Vector3.up * speed;
			//transform.eulerAngles = Vector3.forward * 180;

		}
		if(Input.GetKey(KeyCode.S)){
			GetComponent<Rigidbody2D> ().velocity += Vector2.down*speed;
			//transform.position+=Vector3.down * speed;
			//transform.eulerAngles = Vector3.forward * 0;

		}
	}
}