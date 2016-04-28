using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SecondChoiceScript : MonoBehaviour {

	ChoiceController choices = null;

	// Use this for initialization
	void Start () {
		choices = (ChoiceController) FindObjectOfType(typeof(ChoiceController));
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
			choices.age += (choices.chosePlanner ? 10 : 20)
				+ (choices.choseCivic ? 10 : 20);
		}

		if (didChooseFinancialPlanner) {
			SceneManager.LoadSceneAsync("Financial Advisor");
		}
		else {
			SceneManager.LoadSceneAsync("Vacation Scene");
		}
	}
}
