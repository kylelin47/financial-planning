using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ToLastScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void toLastScene() {
		SceneManager.LoadSceneAsync("scene3");
	}
}
