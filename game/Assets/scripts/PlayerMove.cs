using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove: MonoBehaviour {


	public float speed = 10f;
	public float jumpForce = 100f;
	private float xSpeed; 
	private Rigidbody2D rb;
	private Animator anim;  
	private SpriteRenderer renderer;

	public bool grounded;
	public Transform groundCheck;
	public LayerMask whatIsGround;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		renderer = GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Jump")) {
			rb.AddForce (new Vector2 (0, jumpForce));
		}

		xSpeed = Input.GetAxisRaw ("Horizontal") * speed;
		rb.velocity = new Vector2 (xSpeed, rb.velocity.y);
		anim.SetFloat ("Speed", Mathf.Abs(xSpeed));

		anim.SetBool ("Grounded", grounded);

		if (xSpeed > 0 && renderer.flipX || (xSpeed < 0 && !renderer.flipX)){
			renderer.flipX = !renderer.flipX;
		}


		grounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, whatIsGround);

		if (Input.GetButtonDown ("Jump") && grounded) {
			rb.AddForce (new Vector2 (10, jumpForce));
		}

	}
}