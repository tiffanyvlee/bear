using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {


	public Transform newHead;
	Vector3 originalPosition;
	Quaternion originalRotation;



	void OnTriggerEnter2D( Collider2D Collider) {
		originalPosition = transform.position;
		originalRotation = transform.rotation;

		if (Collider.name == "Player") {
			Destroy (gameObject);
			//Vector3 spawnPoint = new Vector3(transform.position.x, Random.Range(5f, -1.0f), 0);
			Instantiate (newHead, originalPosition, originalRotation);
			GameObject scoreH = GameObject.Find("ScoreHolder");
			scoreH.GetComponent<scoreTracker>().addScore(100);
		}
	}
		
}
