using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MakeNewGround : MonoBehaviour {

	public bool makeGround = false;
	public GameObject[] groundPrefab;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Ground")) {
			makeGround = false;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.CompareTag ("Ground")) {
			makeGround = true;
		}
	}

	void OnTriggerStay2D(Collider2D other) {
		if (other.CompareTag ("Ground")) {
			makeGround = false;
		}
	}


	void Update() {
		if (makeGround) {
			int itemNum = Random.Range (0, groundPrefab.Length);
			Vector3 spawnPoint = new Vector3(transform.position.x, Random.Range(1.0f, -5.0f), 0);
			Instantiate (groundPrefab[itemNum], spawnPoint, Quaternion.identity);
			//make some ground
		}
	}
}
