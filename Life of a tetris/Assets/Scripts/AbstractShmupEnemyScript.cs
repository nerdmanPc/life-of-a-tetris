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
}
