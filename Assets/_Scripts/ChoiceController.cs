using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class ChoiceController : MonoBehaviour {
	public bool canMakeChoice;
	public bool choice1;
	public bool choice2;
	public string activeScene;
	public int age;
	// Use this for initialization
	void Start () {
		age = 25;
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
				if (Input.GetButton ("Fire1") || Input.GetKey (KeyCode.Space)) {
					choice1 = true;
					EditorSceneManager.LoadScene ("Kyle - Sportscar");
				} else if (Input.GetButton ("Fire2") || Input.GetKey (KeyCode.N)) {
					choice1 = false;
					EditorSceneManager.LoadScene ("Kyle - Sportscar");
				}
			}
		} else if (activeScene == "Kyle - Sportscar") {
			if (age > 35) {
				Debug.Log ("Move to next scene");
			}
		}
	}
}
