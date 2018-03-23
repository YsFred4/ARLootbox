using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.iOS;

/*makes an object align/rotate to face towards an object*/
public class LookAtTarget : MonoBehaviour {

	//object to face
	[SerializeField] GameObject target;

	// Use this for initialization
	void Start () { }

	// Update is called once per frame
	void Update () {

		//orient to face target object
		if (target != null) {
			transform.LookAt (target.transform.position);
		}
		//otherwise just look at main camera
		else transform.LookAt(Camera.main.transform);
	}
}
