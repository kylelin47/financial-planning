using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AgeDisplay : MonoBehaviour {
	private Text t;
	private ChoiceController cc;
	private CanvasRenderer cr;
	private bool beginIncrement;
	// Use this for initialization
	void Start () {
		cr = GetComponent<CanvasRenderer> ();
		cc = (ChoiceController) FindObjectOfType(typeof(ChoiceController));
		t = GetComponent<Text> ();
		t.text = "Age: " + cc.age;
	}
	private void IncrementAge() {
		t.text = "Age: " + cc.age++;
		Invoke ("IncrementAge", 0.2f);
	}
	// Update is called once per frame
	void Update () {
		if (cr.GetAlpha () >= 1 && !beginIncrement) {
			beginIncrement = true;
			IncrementAge ();
		}
	}
}
