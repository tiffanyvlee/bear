using UnityEngine;
using System.Collections;

public class MakeNewBackground : MonoBehaviour {

	public bool makeBackground = false;
	public GameObject[] backgroundPrefab;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("backround")) {
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
			int itemNum = Random.Range (0, backgroundPrefab.Length);
			Vector3 spawnPoint = new Vector3(transform.position.x, Random.Range(1.0f, -5.0f), 0);
			Instantiate (backgroundPrefab[itemNum], spawnPoint, Quaternion.identity);
			//make some ground
		}
	}
}
