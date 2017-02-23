using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

	public float speed;
	//public Text countText;
	//public Text winText;
	public int rotateSpeed;
	public GameObject camera;

	private Rigidbody rb;
	//private int count;

	public Text loseText;

	void Start (){
		rb = GetComponent<Rigidbody>();
		loseText.text = "";
	}

	void FixedUpdate (){
		Vector3 movement = new Vector3 (0.0f, 0.0f, 0.0f);

		if (Input.GetKey ("d") || Input.GetKey(KeyCode.RightArrow)) {
			movement = transform.right;
		}
		if (Input.GetKey ("a") || Input.GetKey(KeyCode.LeftArrow)) {
			movement = -transform.right;
		} 
		if (Input.GetKey ("w") || Input.GetKey(KeyCode.UpArrow)) {
			movement = transform.forward;
		} 
		if (Input.GetKey ("s") || Input.GetKey(KeyCode.DownArrow)) {
			movement = -transform.forward;
		}

		rb.AddForce (movement * speed);

		if (Input.GetKey ("."))
			transform.Rotate (0, rotateSpeed*Time.deltaTime, 0);
		if (Input.GetKey (","))
			transform.Rotate (0, - rotateSpeed*Time.deltaTime, 0);

	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pick Up")) {
			gameObject.SetActive (false);
			SetLoseText ();
		}

		if (other.gameObject.CompareTag ("Wall")) {
			rb.isKinematic = true;
			SetLoseText ();
		}
	}

	void SetLoseText(){
		loseText.text = "You Lose!";
	}
}
