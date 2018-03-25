using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlatformerControllerScript : MonoBehaviour {

	public float speed;

	public float jumpHeight;

	private Rigidbody2D rb; 

	public List <Transform> floorMarkers = new List<Transform>();

	private bool isOn;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();	

		isOn = true;

	}

	// Update is called once per frame
	void Update () 
	{
		if(isOn){
		    Movimentar ();

		    Pular ();

		    Mola ();
		}
	}

	void OnTriggerEnter2D ( Collider2D other){
		if (other.gameObject.tag == "Spike"){
			
			isOn = false;

			Invoke ("Restart", 3f);
		} else if (other.gameObject.tag == "Goal"){
			
		} else if (other.gameObject.tag == "MovingFloor"){
			transform.parent = other.transform;
		}

	}


	void OnTriggerExit2D ( Collider2D other){
		if (other.gameObject.tag == "Goal"){
			
		} else if (other.gameObject.tag == "MovingFloor"){
			transform.parent = null;
		}

	}

	void Restart(){
		Scene scene = SceneManager.GetActiveScene();

		SceneManager.LoadScene(scene.name);
	}

	void Movimentar()
	{
		float horizontal = Input.GetAxis ("Horizontal");

		if (horizontal != 0) {

			rb.velocity = new Vector2 (horizontal * speed, rb.velocity.y);			 
		} else {
			rb.velocity = new Vector2 (0f, rb.velocity.y);
		}
	}

	bool VerifyFloor(string layer){
		for(int i = 0; i < floorMarkers.Count; i++)
		{
			if (Physics2D.Linecast (this.transform.position, floorMarkers [i].position, 1 << LayerMask.NameToLayer (layer)))
				return true;
		}

		return false;
	}

	void Pular(){

		bool isFloor = VerifyFloor("Floor");

		if(Input.GetKeyDown(KeyCode.Space) && isFloor){
			rb.velocity = (Vector2.up * jumpHeight) ;
		}
	}

	void Mola(){

		bool isFloor = VerifyFloor("Spring");

		if(isFloor){
			rb.velocity = (Vector2.up * 5f) ;
		}
	}
}
