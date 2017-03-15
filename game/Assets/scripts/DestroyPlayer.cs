using UnityEngine;
using System.Collections;

public class DestroyPlayer : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Player")) {
			Destroy (other.gameObject);
			UnityEngine.SceneManagement.SceneManager.LoadScene (2);
		}
	}

//	void Update () {
//		if ( ){
//		}
//	}
}
