using UnityEngine;
using System.Collections;

public class ShowChoice : MonoBehaviour {
	public Transform player;
	public Transform waypoint;
	public float minimumDistance;
	private bool isVisible;
	public ChoiceController cc;
	// Use this for initialization
	void Start () {
		foreach (Transform child in transform) {
			child.gameObject.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (!isVisible && Vector3.Distance (waypoint.position, player.position) < minimumDistance) {
			foreach (Transform child in transform) {
				child.gameObject.SetActive(true);
			}
			isVisible = true;
			cc.canMakeChoice = true;
		}
	}
}
