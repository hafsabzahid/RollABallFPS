using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CameraController : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {}
		
	void LateUpdate (){
		transform.position = player.transform.position;
		transform.rotation = player.transform.rotation;
	}

	void Update(){
		if (Input.GetKey (KeyCode.Return))
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
