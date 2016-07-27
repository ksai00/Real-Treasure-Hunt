using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBox : MonoBehaviour {
	Collider2D ourcollider;
	public Text hint;
	[Multiline] public string exittext=" ";
	[Multiline] public string hintText;
	public bool destroyonexit;
	// Use this for initialization
	void Start () {
		ourcollider = GetComponent<Collider2D> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D player){
		hint.text = hintText;
		
	}
	void OnTriggerExit2D(Collider2D player){
		hint.text = exittext;
		if (destroyonexit) {
			Destroy (gameObject);
		}
	}
}
