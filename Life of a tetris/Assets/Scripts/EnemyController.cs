using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float speed;
    public GameObject bullet;

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start () {
        rb2d = this.transform.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

	}

    void Move (Vector2 direction)
    {
        if (direction == new Vector2(0f, 1f)) {//cima
            this.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            rb2d.velocity = new Vector3(0f, speed * Time.deltaTime, 0f);
        } else if (direction == new Vector2(0f, -1f)) {//baixo
            this.transform.eulerAngles = new Vector3(0f, 0f, 180f);
            rb2d.velocity = new Vector3(0f, -speed * Time.deltaTime, 0f);
        } else if (direction == new Vector2(-1f, 0f)) {//esquerda
            this.transform.eulerAngles = new Vector3(0f, 0f, 90f);
            rb2d.velocity = new Vector3(-speed * Time.deltaTime, 0f, 0f);
        } else if (direction == new Vector2(1f, 0f)) {//direita
            this.transform.eulerAngles = new Vector3(0f, 0f, 270f);
            rb2d.velocity = new Vector3(speed * Time.deltaTime, 0f, 0f);
        } else {//parar
            rb2d.velocity = new Vector3(0f, 0f, 0f);
        }
    }

    void Aim (Vector2 direction)
    {
        if (direction == new Vector2(0f, 1f)) {//cima
            this.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        } else if (direction == new Vector2(0f, -1f)) {//baixo
            this.transform.eulerAngles = new Vector3(0f, 0f, 180f);
        } else if (direction == new Vector2(-1f, 0f)) {//esquerda
            this.transform.eulerAngles = new Vector3(0f, 0f, 90f);
        } else if (direction == new Vector2(1f, 0f)) {//direita
            this.transform.eulerAngles = new Vector3(0f, 0f, 270f);
        }
    }

    void Shoot()
    {
        Instantiate(bullet, this.transform.position, this.transform.rotation);
    }
}
