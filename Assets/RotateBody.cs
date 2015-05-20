using UnityEngine;
using System.Collections;

public class RotateBody : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Rotate () {
		iTween.RotateBy(gameObject, iTween.Hash("y", .50, "easeType", "easeInCubic"));
	}
}
