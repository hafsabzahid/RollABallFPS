using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shooter : MonoBehaviour {

	public Rigidbody bullet;
	public int speed;
	public GameObject cube;
	private Rigidbody bull;

	void Start(){
		bullet.gameObject.SetActive (false);
	}
		
	void Update() {

		bullet.position = cube.transform.position;
		bullet.rotation = cube.transform.rotation;

		if(Input.GetKeyDown(KeyCode.Space))
		{
			bullet.gameObject.SetActive (true);
			bull = Instantiate(bullet, cube.transform.position, cube.transform.rotation);
			bullet.gameObject.SetActive (false);
			bull.AddForce (bullet.transform.forward * speed);
		}
	}
}
