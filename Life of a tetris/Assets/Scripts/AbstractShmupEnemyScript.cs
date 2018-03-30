using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractShmupEnemyScript : MonoBehaviour {

	public int damage;
	public int hp;

	protected void LifeManagement(){
		if(hp == 0){
			Destroy (this.gameObject);
		}
	}

	protected void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Bullet")
			hp = hp - 1;
	}

	protected void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Bullet")
			hp = hp - 1;
	}

	protected void OutOfBorders(){
		if (this.transform.position.x > 2.2f)
			this.transform.position = new Vector3 (-2.15f, this.transform.position.y, this.transform.position.z);
		if (this.transform.position.x < -2.2f)
			this.transform.position = new Vector3 (2.15f, this.transform.position.y, this.transform.position.z);
	}
}
