using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShmupGoAnBackEnemyScript : AbstractShmupEnemyScript {

	private Rigidbody2D rb2d;
	public float forceSpeedX;
	public float posForceSpeedX;
	public float negForceSpeedX;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		posForceSpeedX = forceSpeedX;
		negForceSpeedX = -forceSpeedX;
	}
	
	// Update is called once per frame
	void Update () {
		LifeManagement ();
		Moviment ();
		BackAndGo ();
	}

	void Moviment (){
		Vector2 force = new Vector2 (forceSpeedX, -0.5f);
		rb2d.AddForce(force);
	}

	void BackAndGo(){
		if (this.transform.position.x > 1.8f)
			forceSpeedX = negForceSpeedX;		
		if(this.transform.position.x < -1.8f)
			forceSpeedX = posForceSpeedX;
	}
}
