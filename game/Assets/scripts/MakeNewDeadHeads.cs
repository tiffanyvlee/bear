using UnityEngine;
using System.Collections;

public class MakeNewDeadHeads : MonoBehaviour {

	public bool makeSadHead = false;
	public GameObject[] sadPrefab;

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
			int itemNum = Random.Range (0, 1);
			Vector3 spawnPoint = new Vector3(transform.position.x, Random.Range(1.0f, -2.0f), 0);
			Instantiate (sadPrefab[itemNum], spawnPoint, Quaternion.identity);
			//make some ground
		}
	}
}

//
//	public Transform thingToSpawn;
//	private float Timer;
//	public float time = 5;
//	public int numToSpawn = 10;
//
//	GameObject[] storedSpawns;
//
//	void Awake() {
//		Timer = Time.time + 7;
//	}
//
//	void Update () {
//
//		if (Timer < Time.time) {
//			storedSpawns = new GameObject[numToSpawn];
//			for (int i = 0; i<storedSpawns.Length; i++) {
//				//storedSpawns [i] = Instantiate (thingToSpawn, Random.insideUnitSphere * 3, Quaternion.identity) as GameObject;
//			}
//			Timer = Time.time + time;
//		}
//	
//	}
//}
