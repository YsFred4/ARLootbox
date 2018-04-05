using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*touch detection base from https://stackoverflow.com/questions/38565746/tap-detection-on-a-gameobject-in-unity*/
public class tap_manager : MonoBehaviour {

	public Animator boxAnimation;
	public GameObject box;
	Giftbox_handler boxScript;

	// Use this for initialization
	void Start () {
		boxScript = box.GetComponent<Giftbox_handler>();
	}

	// Update is called once per frame
	void Update () {
		if ((Input.touchCount > 0) && (Input.GetTouch (0).phase == TouchPhase.Began)) {
			Ray raycast = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
			RaycastHit raycastHit;
			if (Physics.Raycast (raycast, out raycastHit)) {

				//by name
				if (raycastHit.collider.name == "test") {
					Debug.Log ("test(name) clicked");
				}

				if (raycastHit.collider.CompareTag ("MyBox")) {
					if (boxScript.open) {
						boxScript.closeBox ();
						boxScript.open = false;
					}
					else {
						boxScript.openBox ();
						boxScript.open = true;
					}
					Debug.Log ("box tapped");
				}
					
				//by tag
				if (raycastHit.collider.CompareTag ("test")) {
					Debug.Log ("test(tag) clicked");
				}
			}
		}
	}
}
