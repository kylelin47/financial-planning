using UnityEngine;
using System.Collections;

public class ChoiceController : MonoBehaviour {
	public bool choice1;
	public bool choice2;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
