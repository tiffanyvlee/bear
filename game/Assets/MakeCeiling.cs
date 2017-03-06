using UnityEngine;
using System.Collections;

public class MakeCeiling : MonoBehaviour {

	public bool makeCeiling = false;
	public GameObject[] ceilingPrefab;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Ceiling")) {
			makeCeiling = false;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.CompareTag ("Ceiling")) {
			makeCeiling = true;
		}
	}

	void OnTriggerStay2D(Collider2D other) {
		if (other.CompareTag ("Ceiling")) {
			makeCeiling = false;
		}
	}


	void Update() {
		if (makeCeiling) {
			int itemNum = Random.Range (0, 1);
			Vector3 spawnPoint = new Vector3(transform.position.x, 5.5f, 0);
			Instantiate (ceilingPrefab[itemNum], spawnPoint, Quaternion.identity);
			//make some ground
		}
	}
}
