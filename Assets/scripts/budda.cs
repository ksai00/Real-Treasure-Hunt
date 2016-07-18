using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class budda : MonoBehaviour {

	public Text myTextObject;             // assign in inspector, Text UI
	public Transform PlayerCharacter;         // assign in inspector, player

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if ( (PlayerCharacter.position - transform.position).magnitude < 3f ) {
			myTextObject.text = "Life is suffering, but I can show you the way. \nJust read The Crazy Eights-fold Path, \nmy new ebook/memoir on Kindle and Amazon...\nHey, self promotion is my RIGHT!";

		}
	} 
} 