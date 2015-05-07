using UnityEngine;
using System.Collections;

public class BlipControl : MonoBehaviour {
	 Renderer rend;
	public Material colorChange;
	public Material defaultColor;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void OnMouseEnter() {
		rend.material = colorChange;
	}

	void OnMouseExit () {
		rend.material = defaultColor;
	
	}
}
