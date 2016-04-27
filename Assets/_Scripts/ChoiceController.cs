using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class ChoiceController : MonoBehaviour {
	public bool canMakeChoice;
	public bool choseCivic; // true if chose civic
	public bool chosePlanner; // true if chose financial planner
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
		if (activeScene == "Kyle - Sportscar") {
			if (age >= 31) {
				age = 30;
				EditorSceneManager.LoadScene ("_Scenes/Office Scene Bonus");
			}
		}
	}
	public void SelectSportscar() {
		if (canMakeChoice) {
			choseCivic = false;
			EditorSceneManager.LoadScene ("Kyle - Sportscar");
		}
	}
	public void SelectCivic() {
		if (canMakeChoice) {
			choseCivic = true;
			EditorSceneManager.LoadScene ("Kyle - Sportscar");
		}
	}
}
