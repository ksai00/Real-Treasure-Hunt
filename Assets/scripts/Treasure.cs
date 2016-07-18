using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

	public class Treasure : MonoBehaviour {

	bool didPlayerWin = false;
	public Text myTextObject;             // assign in inspector, Text UI
	public Transform PlayerCharacter;         // assign in inspector, player

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( (PlayerCharacter.position - transform.position).magnitude < 3f ) {
			myTextObject.text = "Could it be? The meaning of life is...\nPress [SPACE] to find out";
			if (Input.GetKeyDown (KeyCode.Space) ) {
				didPlayerWin = true;
			}
		}
		if (didPlayerWin) {
			SceneManager.LoadScene (1);
		}
	} 
} 