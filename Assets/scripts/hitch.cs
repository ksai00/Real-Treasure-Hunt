using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hitch : MonoBehaviour {

	public Text myTextObject;             // assign in inspector, Text UI
	public Transform PlayerCharacter;         // assign in inspector, player

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if ( (PlayerCharacter.position - transform.position).magnitude < 3f ) {
			myTextObject.text = "C'mon, this reference is BENEATH you.";

		}
	} 
} 