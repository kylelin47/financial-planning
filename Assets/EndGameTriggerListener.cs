using UnityEngine;
using System.Collections;

public class EndGameTriggerListener : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Cardboard.SDK.CardboardTriggered) {
			Application.LoadLevel(0);
		}
	}
}
