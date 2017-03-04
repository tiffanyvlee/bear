using UnityEngine;
using System.Collections;

public class DestroyGround : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Ground")) {
			Destroy (other.gameObject);
		}
	}
}
