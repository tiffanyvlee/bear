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
			int itemNum = Random.Range (0, 1);
			Vector3 spawnPoint = new Vector3(transform.position.x+2f, Random.Range(-5.0f, -9.0f), 0);
			Vector3 spawnPoint2 = new Vector3(transform.position.x + 3f, Random.Range(-5.0f, -8.0f), 0);
			Vector3 spawnPoint3 = new Vector3(transform.position.x + 7f, Random.Range(-4.0f, -9.0f), 0);
			Instantiate (groundPrefab[0], spawnPoint, Quaternion.identity);
			Instantiate (groundPrefab[1], spawnPoint2, Quaternion.identity);
			Instantiate (groundPrefab[2], spawnPoint3, Quaternion.identity);
			//make some ground
		}
	}
}
