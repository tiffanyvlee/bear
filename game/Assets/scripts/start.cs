using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

	public void LoadScene(string game) {
		UnityEngine.SceneManagement.SceneManager.LoadScene (1);
	}

	void Update () {
		if ( Input.GetKey( KeyCode.Return ) ) {
			UnityEngine.SceneManagement.SceneManager.LoadScene (1);
		}
	}
}
