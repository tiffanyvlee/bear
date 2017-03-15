using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour {

	Vector3 origLocation;
	Quaternion origRotation;

	public Transform playerTransform;

	public float numSecondsToShake = 2f;
	public float intensity = 4f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (playerTransform.position.x, 0, -3);

		origLocation = transform.position;
		origRotation = transform.rotation;
		if (Input.GetKeyDown(KeyCode.Return)) {
			StartCoroutine("shakeCam");
		}
	}

	IEnumerator shakeCam() {
		// shake for a number of seconds
		float timeLeft = numSecondsToShake;
		while (timeLeft > 0) {
			//			transform.LookAt(GameObject.Find("Cylinder").transform.position);
			transform.position = origLocation + Random.insideUnitSphere * intensity;
			timeLeft -= Time.deltaTime;
			yield return null; // stops the loop from contining this time
		}
		// return the camera to the orig position
		transform.position = origLocation;
		transform.rotation = origRotation;
	}
}


//	Transform origLocation;
//
//	public float numSecondsToShake = 1f;
//
//	// Use this for initialization
//	void Start () {
//		origLocation = transform;
//	}
//
//	// Update is called once per frame
//	void Update () {
//
//		//transform.position = origLocation.position + Random.insideUnitSphere;
//		if (Input.GetKeyDown (KeyCode.Return)) {
//			StartCoroutine ("shakeCam");
//		}
//	}
//	IEnumerator shakeCam() {
//
//		//shake for a number of seconds
//		float timeLeft = numSecondsToShake;
//		while (timeLeft > 0) {
//			transform.position = origLocation.position + Random.insideUnitSphere;
//			timeLeft -= Time.deltaTime;
//			yield return null;  //stops the loop from continuing this time
//		}
//		//return the camera to the orig position;
//		transform.position = origLocation.position;
//
//	}
//}
