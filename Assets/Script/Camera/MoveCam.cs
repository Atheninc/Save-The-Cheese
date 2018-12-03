using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
	public bool XFollow;
	public bool YFollow;
    private GameObject Player;
	
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    
    void Update()
    {
		var a = transform.position;
		if (YFollow)
			a.y = Player.transform.position.y;
		if (XFollow)
			a.x = Player.transform.position.x;
		a.z = -10;
        transform.position = a;
    }
}
