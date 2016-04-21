using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class ChoiceController : MonoBehaviour {
	public bool choice1;
	public bool choice2;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
		Debug.Log(EditorSceneManager.GetActiveScene ().name);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
