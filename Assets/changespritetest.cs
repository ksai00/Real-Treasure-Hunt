using UnityEngine;
using System.Collections;

public class changespritetest : MonoBehaviour {
	SpriteRenderer ourspriterenderer;
	public Sprite newsprite;

	// Use this for initialization
	void Start () {
		ourspriterenderer = GetComponent<SpriteRenderer> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			ourspriterenderer.sprite = newsprite;
		}
	
	}
}
