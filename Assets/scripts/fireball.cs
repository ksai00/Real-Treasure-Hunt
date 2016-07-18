using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fireball : MonoBehaviour {

	public Text myTextObject;             // assign in inspector, Text UI
	public Transform PlayerCharacter;         // assign in inspector, player

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if ( (PlayerCharacter.position - transform.position).magnitude < 3f ) {
			myTextObject.text = "You've hit rock bottom. Literally. \nBut now things will start to look UP!";

		}
	} 
} 