using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class love : MonoBehaviour {

	public Text myTextObject;             // assign in inspector, Text UI
	public Transform PlayerCharacter;         // assign in inspector, player

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if ( (PlayerCharacter.position - transform.position).magnitude < 3f ) {
			myTextObject.text = "Love is patient, love is kind, \nlove is an abstract concept...\nI feel so passionate I can hardly stay UPRIGHT!";

		}
	} 
} 