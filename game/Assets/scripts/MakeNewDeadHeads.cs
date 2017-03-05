using UnityEngine;
using System.Collections;

public class MakeNewDeadHeads : MonoBehaviour {

	public Transform thingToSpawn;
	private float Timer;

	public int numToSpawn = 100;

	GameObject[] storedSpawns;

	void Awake() {
		Timer = Time.time + 3;
	}

	void Update () {

		if (Timer < Time.time) {
			storedSpawns = new GameObject[numToSpawn];
			for (int i = 0; i<storedSpawns.Length; i++) {
				storedSpawns [i] = Instantiate (thingToSpawn, Random.insideUnitSphere * 3, Quaternion.identity) as GameObject;
			}
			Timer = Time.time + 5;
		}
	
	}
}
