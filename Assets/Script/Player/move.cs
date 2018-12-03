using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    public float jump_Force;
	public bool ground;
	public bool wall;
	public SoundPlayer sp;
	private AudioSource source;
	
	private int count;
	private float t;
	private Animator anim;
    private SpriteRenderer sr;
	private Rigidbody2D rb;
	
    void Start()
	{
		source = GetComponent<AudioSource>();
		source.clip = sp.restart;
		source.Play();
        rb = gameObject.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
		
	}
	void Update()
    {
		t = Time.deltaTime;
		var dir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		if (Input.GetButtonDown("Fire1"))
		{
			var b = rb.velocity;
			b.y = 0;
			if (ground || count < 1){
				rb.velocity = b;
				rb.AddForce(transform.up * jump_Force, ForceMode2D.Impulse);
				source.clip = sp.jump;
				source.Play();
			}
			else if (wall)
			{
				rb.velocity = b;
				rb.AddForce((transform.up + (transform.right * -dir.x)) * jump_Force, ForceMode2D.Impulse);
			}
			count++;
		}
		var a = rb.velocity;

        anim.SetFloat("speed", Mathf.Abs(dir.x));
        if (dir.x < 0)
            sr.flipX = true;
        else
            sr.flipX = false;
		a.x = dir.x;
		rb.velocity = a;
		a.x  = speed * dir.x;
		rb.velocity = a;
	}
	
	void OnCollisionStay2D(Collision2D other)
	{
		foreach (ContactPoint2D item in other.contacts)
		{
			var a = Mathf.Atan2(item.normal.x, item.normal.y) * 180 / Mathf.PI;
			if (a > -45 && a < 45)
			{
				ground = true;
				count = 0;
			}
			if (a >= 45 && a <= 135)
			{
				wall = true;
				count = 0;
			}
			if (a <= -45 && a >= -135)
			{
				wall = true;
				count = 0;
			}
		}
	}
	void OnCollisionExit2D(Collision2D other){
		ground = false;	
		wall = false;
	}
}
