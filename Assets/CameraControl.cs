using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void wristLook () {
		iTween.RotateBy(gameObject, iTween.Hash("y", .25, "easeType", "easeInOutQuad"));
	}

	public void wristLookBack () {
		iTween.RotateBy(gameObject, iTween.Hash("y", -.25, "easeType", "easeInOutQuad"));
	}

	public void kneeLook () {
		iTween.RotateBy(gameObject, iTween.Hash("x", .25, "easeType", "easeInOutQuad"));
	}

	public void kneeLookBack () {
		iTween.RotateBy(gameObject, iTween.Hash("x", -.25, "easeType", "easeInOutQuad"));
	}
}
