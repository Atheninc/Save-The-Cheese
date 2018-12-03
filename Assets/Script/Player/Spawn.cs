using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{
	
    void Start()
    {
		
    }
	
	
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
		{
			reload();
		}
    }
	
	public static void reload()
	{
		
			Scene scene = SceneManager.GetActiveScene();
			SceneManager.LoadScene(scene.name);
	}
}
