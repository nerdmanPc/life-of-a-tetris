﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	public float speed;

		
	// Update is called once per frame
	void Update () {
		transform.Translate (0, speed * Time.deltaTime, 0);	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Destroy(this.gameObject);
	}
}
