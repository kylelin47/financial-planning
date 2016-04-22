using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class ChoiceController : MonoBehaviour {
	public bool canMakeChoice;
	public bool choice1;
	public bool choice2;
	public string activeScene;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
		activeScene = EditorSceneManager.GetActiveScene ().name;
		Debug.Log (activeScene);
	}
	void OnLevelWasLoaded(int level) {
		canMakeChoice = false;
		activeScene = EditorSceneManager.GetActiveScene ().name;
		Debug.Log (activeScene);
	}
	// Update is called once per frame
	void Update () {
		if (activeScene == "Kyle - Choice 1") {
			if (canMakeChoice) {
				if (Input.GetButton("Fire1") || Input.GetKey(KeyCode.Space)) {
					EditorSceneManager.LoadScene("Kyle - Sportscar");
				}
			}
		}
	}
}
