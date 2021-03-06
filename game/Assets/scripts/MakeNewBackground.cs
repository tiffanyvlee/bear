﻿using UnityEngine;
using System.Collections;

public class MakeNewBackground : MonoBehaviour {

	public bool makeBackground = false;
	public GameObject[] backgroundPrefab;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("background")) {
			makeBackground = false;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.CompareTag ("background")) {
			makeBackground = true;
		}
	}

	void OnTriggerStay2D(Collider2D other) {
		if (other.CompareTag ("background")) {
			makeBackground = false;
		}
	}


	void Update() {
		if (makeBackground) {
			int itemNum = Random.Range (0, 1);
			Vector3 spawnPoint = new Vector3(transform.position.x, 0f, 7f);
			Instantiate (backgroundPrefab[itemNum], spawnPoint, Quaternion.identity);
			//make some ground
		}
	}
}
