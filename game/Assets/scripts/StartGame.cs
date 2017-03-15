using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public void LoadScene(string game) {
	UnityEngine.SceneManagement.SceneManager.LoadScene (2);
	}


	void Update () {
		if ( Input.GetKey( KeyCode.Return ) ) {
			UnityEngine.SceneManagement.SceneManager.LoadScene (2);
		}
	}
}
