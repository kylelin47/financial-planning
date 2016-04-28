using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndGameText : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent<Text>();

		int age = 30;
		int wealth = 6000000;
		int earnings = wealth/10;

		text.text = string.Format(
			"You retired at age {0} with {1:C0} invested.\n\nAt a rate of 10%, this will earn you {2:C0} per year.",
			age,
			wealth,
			earnings
		);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
