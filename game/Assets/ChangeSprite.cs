using UnityEngine;
using System.Collections;

public class ChangeSprite : MonoBehaviour {
	SpriteRenderer renderer;
	Sprite Black;
	Sprite White;

	// Use this for initialization
	void Start () {
		Black = Resources.Load<Sprite> ("SadHead");
		White = Resources.Load<Sprite> ("DeadHead");
		renderer = GetComponent<SpriteRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D Collider){
		renderer.sprite = Black;
	}
	void OnTriggerExit2D(Collider2D Collider) {
		renderer.sprite = White;

	}
}
