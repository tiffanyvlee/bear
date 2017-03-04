using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class move : MonoBehaviour {

	private float xMove = 0.0f;
	public float speed = 10f;
	public float height = 5f;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward * 360 * Time.deltaTime);

		xMove += (Time.deltaTime * speed);
		Vector2 newPosition = transform.position;
		newPosition.y = Mathf.Sin (xMove) * height;

		transform.position = newPosition;
	}
}
