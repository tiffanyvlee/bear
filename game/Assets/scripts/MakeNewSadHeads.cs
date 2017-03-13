using UnityEngine;
using System.Collections;

public class MakeNewSadHeads : MonoBehaviour {

	public bool makeSadHead = false;
	public GameObject[] SadHeadPrefab;
	//public GameObject sadHead;
	//public float spawnTime=1f;
	//public Transform[] spawnPoints;

//	void start() {
//		InvokeRepeating ("Spawn", spawnTime, spawnTime);
//	}

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
//			int spawnPointIndex = Random.Range (0, spawnPoints.Length);
//			Instantiate (sadHead, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

			int itemNum = Random.Range (0, SadHeadPrefab.Length);
			Vector3 spawnPoint = new Vector3(transform.position.x, Random.Range(4.5f, -4.5f), 0);
			Instantiate (SadHeadPrefab[itemNum], spawnPoint, Quaternion.identity);
//			//make some ground
		}

	}

}
