using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int speed = 12;
	public int gravity = 6;
	public int jumpForce = 475;
	public float jumpSpeed = 3f;
	private bool onGround = true;
	private bool facingRight = true;
	
	private Animator anim;

	void Start()
	{
		anim = GetComponent<Animator>();
	}

	void Flip()
	{
		facingRight = !facingRight;
		
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	void Update()
	{
		//Fetch Input for movement on the X Axis
		if(Input.GetKey(KeyCode.A))
		{
			this.transform.Translate(Vector3.left * speed * Time.deltaTime);
			if(facingRight)
			{
				Flip();      
			}
		}
		if(Input.GetKeyUp(KeyCode.A))
		{
			if(!facingRight)
			{
				Flip();
			}
		}

		if(Input.GetKey(KeyCode.D))
		{
			this.transform.Translate(-Vector3.left * speed * Time.deltaTime);
			if(!facingRight)
			{
				Flip();
			}
		}

		//If you're on the ground you will be able to jump
		if(onGround == true)
		{
			//If W is pressed you will Jump
			if(Input.GetKeyDown(KeyCode.W))
			{
				Jump();
				anim.SetBool("Jump", true);
			}	
		}
	}

	//Jump Physics
	void Jump()
	{
		this.transform.rigidbody2D.AddForce(Vector3.up * jumpSpeed * jumpForce);
		onGround = false;
	}
	
	//Checks if you're on the ground
	void OnCollisionEnter2D (Collision2D hit)
	{
		if(hit.transform.tag == "platform")
		{
			onGround = true;
			anim.SetBool("Jump", false);
		}
	}

	void OnBecameInvisible()
	{
		Application.LoadLevel("Deathscreen");
	}
}