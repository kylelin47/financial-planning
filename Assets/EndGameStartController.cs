using UnityEngine;
using System.Collections;

public class EndGameStartController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ChoiceController cc = (ChoiceController) FindObjectOfType(typeof(ChoiceController));

		bool isRich = cc.choseCivic;
		Vector3 targetPosition = transform.position;
		Quaternion targetRotation = transform.rotation;

		if (!isRich) {
			targetPosition.x = -121.29f;
			targetRotation.y = 83.9f;
		}
		
		transform.position = targetPosition;
		transform.rotation = targetRotation;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
