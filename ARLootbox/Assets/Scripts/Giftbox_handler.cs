using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giftbox_handler : MonoBehaviour {


	public Animator anim;
	public Animator prize_anim;
	public GameObject prize;
	public List<GameObject> prizeList;
	public Animator popup_anim;
	public ParticleSystem particles;
	public bool open;
	public Transform prizeSlot;

	// Use this for initialization
	void Start () {
		getNewPrize ();
		particles.Pause ();
		open = false;
	}

	// Update is called once per frame
	void Update () { }

	void getNewPrize() {
		GameObject.Destroy (prize);
		prize = prizeList[Random.Range(0, (prizeList.Count-1))].gameObject;
		Debug.Log ("current prize: " +prize.name);
		prize = GameObject.Instantiate (prize, prizeSlot);
		//prize.transform.SetParent(prizeSlot);
	}
		
	void triggerBox(){
		Debug.Log ("open done");
		if (!open) {
			prize_anim.SetBool ("enter", false);
			prize_anim.SetBool("leave", true);
			particles.Stop ();
		}
		else{
			prize_anim.SetBool("enter", true);
			prize_anim.SetBool("leave", false);
			particles.Play ();
		}
	}

	public void closeBox(){
		Debug.Log ("closing box");
		stopParticles ();
		anim.SetBool("open",false);
		anim.SetBool("close",true);
	}

	public void openBox(){
		Debug.Log ("opening box"); 
		anim.SetBool("open",true);
		anim.SetBool("close",false);
		getNewPrize ();
	}


	void startParticles(){
		if (open) {
			prize_anim.SetBool("enter", true);
			prize_anim.SetBool("leave", false);
		}
		popup_anim.SetTrigger ("leave");

	}

	void stopParticles(){
		particles.Stop ();
	}

}
