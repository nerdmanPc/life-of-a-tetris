using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShmupAsteroidScript : AbstractShmupEnemyScript {

	private Rigidbody2D rb2d;
	private float _rotation;
	private float speedX;


	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		speedX = Random.Range (-1f, 1f);
		_rotation = Random.Range (-1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		Moviment ();
		LifeManagement ();
	}

	void Moviment (){
		rb2d.velocity = new Vector3( speedX, -0.5f, 0f);
		transform.Rotate (0f, 0f, _rotation * 90f * Time.deltaTime);
	}


}
