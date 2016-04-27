using UnityEngine;
using System.Collections;

public class TriggerCapture : MonoBehaviour {

	public TriggerManager triggerFunction;

	public delegate void TriggerManager();

	void OnTriggerEnter(Collider other) {
		if (triggerFunction != null) {
			triggerFunction();
		}
		triggerFunction = null;
	}
	
}
