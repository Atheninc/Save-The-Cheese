﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player")
		{
			Spawn.reload();
		}
	}
}
