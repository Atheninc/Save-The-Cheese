using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chees : MonoBehaviour
{
	public static int point;
	public SoundPlayer sp;
	private AudioSource source;
	
	void Start()
	{
		source = GetComponent<AudioSource>();
	}
	
	public void AddPoint()
	{
		point += 1;
		source.clip = sp.Cheese;
		source.Play();
	}
	
    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "cheese")
		{
			AddPoint();
            DataLevel.cheese++;
			Destroy(other.gameObject);
		}
		
	}
}
