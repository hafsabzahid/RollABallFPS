using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bullet : MonoBehaviour {

	private static int hits;
	public Text hitsText;
	public Text winText;
	private float timer = 3;

	// Use this for initialization
	void Start () {
		winText.text = "";
	}

	void Update () {
		timer -= Time.deltaTime * 10;
		if (timer <= 0)
			gameObject.SetActive (false);

		if (Input.GetKey (KeyCode.Return))
			hits = 0;
	}
		
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			hits++;
			SetHitsText ();
		}
	}

	void SetHitsText(){
		hitsText.text = "Hits: " + hits.ToString ();
		if (hits >= 14) {
			winText.text = "You Win!";
		}
	}
}
