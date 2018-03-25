using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShmupControllerScript : MonoBehaviour {

	private Rigidbody2D rb2d;

	public float speed;

	public GameObject bullet;

	// Use this for initialization
	void Start () {
		rb2d = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
		Shoot ();
	}

	void Movement(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0f);

		rb2d.velocity = movement * speed;
	}

	void Shoot(){
		if(Input.GetKeyDown (KeyCode.Space)){
			Instantiate(bullet ,this.transform.position ,this.transform.rotation);
		}
	}
}
