using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    
	public string to;
	public void ChangeScene()
	{
		SceneManager.LoadScene(to);
	}
	void onClick()
	{
		ChangeScene();
	}
}
