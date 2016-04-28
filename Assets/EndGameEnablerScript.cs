using UnityEngine;
using System.Collections;

public class EndGameEnablerScript : MonoBehaviour {

	public GameObject endGame;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			endGame.SetActive(true);
		}
	}
}
