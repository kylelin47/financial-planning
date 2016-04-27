using UnityEngine;
using System.Collections;

public class SwitchCars : MonoBehaviour {
	public CardboardAudioSource sportsCarSound;
	public CardboardAudioSource coupeRadio;
	public GameObject player;
	public GameObject driverAvatar;
	public Transform civicTransform;
	public Transform civicWaypoint;
	private ChoiceController cc;
	// Use this for initialization
	void Start () {
		cc = (ChoiceController) FindObjectOfType(typeof(ChoiceController));
		if (cc.choseCivic) {
			player.transform.position = civicWaypoint.position;
			player.transform.parent = civicWaypoint;
			player.transform.rotation = civicWaypoint.rotation;
			sportsCarSound.volume = 1;
		} else {
			coupeRadio.volume = 0;
			driverAvatar.SetActive (false);
		}
	}
	// Update is called once per frame
	void Update () {
	}
}
