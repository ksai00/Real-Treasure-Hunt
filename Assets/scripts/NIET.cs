using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NIET : MonoBehaviour {

	public Text myTextObject;             // assign in inspector, Text UI
	public Transform PlayerCharacter;         // assign in inspector, player

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if ( (PlayerCharacter.position - transform.position).magnitude < 3f ) {
			myTextObject.text = "Man is a rope, stretched between \nanimal and...nevermind, I can see this is going \nOVER your head";

		}
	} 
} 