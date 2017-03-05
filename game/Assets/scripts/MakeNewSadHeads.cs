using UnityEngine;
using System.Collections;

public class MakeNewSadHeads : MonoBehaviour {

	public bool makeSadHead = false;
	public GameObject[] SadHeadPrefab;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("SadHead")) {
			makeSadHead = false;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.CompareTag ("SadHead")) {
			makeSadHead = true;
		}
	}

	void OnTriggerStay2D(Collider2D other) {
		if (other.CompareTag ("SadHead")) {
			makeSadHead = false;
		}
	}


	void Update() {
		if (makeSadHead) {
			int itemNum = Random.Range (0, SadHeadPrefab.Length);
			Vector3 spawnPoint = new Vector3(transform.position.x, Random.Range(5.0f, -15.0f), 0);
			Instantiate (SadHeadPrefab[itemNum], spawnPoint, Quaternion.identity);
			//make some ground
		}
	}
}
