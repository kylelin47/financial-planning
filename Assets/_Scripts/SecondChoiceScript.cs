using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SecondChoiceScript : MonoBehaviour {

	ChoiceController choices = null;

	// Use this for initialization
	void Start () {
		choices = GameObject.FindWithTag("persistent").GetComponent<ChoiceController>();
		Debug.Log(choices);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void chooseFinancialPlanner() {
		Debug.Log("Financial Planner Chosen");
		makeChoice(true);
	}

	public void chooseTravelAgent() {
		Debug.Log("Vacation Chosen");
		makeChoice(false);
	}

	void makeChoice(bool didChooseFinancialPlanner) {
		if (choices != null) {
			choices.chosePlanner = didChooseFinancialPlanner;
		}

		if (didChooseFinancialPlanner) {
			SceneManager.LoadSceneAsync("Financial Advisor");
		}
		else {
			SceneManager.LoadSceneAsync("Vacation Scene");
		}
	}
}
