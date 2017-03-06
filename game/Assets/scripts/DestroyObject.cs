using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {


	public Transform newHead;

	void OnTriggerEnter2D( Collider2D Collider) {
		if (Collider.name == "Player") {
			Destroy (gameObject);
			Vector3 spawnPoint = new Vector3(transform.position.x, Random.Range(1.0f, -2.0f), 0);
			Instantiate (newHead, spawnPoint, Quaternion.identity);
		}
	}
}
