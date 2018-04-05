using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup_Display : MonoBehaviour {

	public Animator anim;
	public GameObject reset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void onAnimDone(){
		Debug.Log ("popup open");
		reset.SetActive (true);
	}
}
