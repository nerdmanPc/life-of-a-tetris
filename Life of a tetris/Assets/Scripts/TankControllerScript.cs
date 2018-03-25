using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControllerScript : MonoBehaviour {

	public float speed;

	public GameObject bullet;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = this.transform.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
		Shoot ();
	}

	void Movement(){
		if (Input.GetKey (KeyCode.UpArrow)) {
			this.transform.eulerAngles = new Vector3 (0f, 0f, 0f);
			rb2d.velocity = new Vector3 (0f, speed * Time.deltaTime, 0f);
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			this.transform.eulerAngles = new Vector3 (0f, 0f, 180f);
			rb2d.velocity = new Vector3 (0f, -speed * Time.deltaTime, 0f);
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.eulerAngles = new Vector3 (0f, 0f, 90f);
			rb2d.velocity = new Vector3 (-speed * Time.deltaTime, 0f, 0f);
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.eulerAngles = new Vector3 (0f, 0f, 270f);
			rb2d.velocity = new Vector3 (speed * Time.deltaTime, 0f, 0f);
		} else {
			rb2d.velocity = new Vector3 (0f, 0f, 0f);
		}
	}

	void Shoot(){
		if(Input.GetKeyDown (KeyCode.Space)){
			Instantiate(bullet ,this.transform.position ,this.transform.rotation);
		}
	}
}
