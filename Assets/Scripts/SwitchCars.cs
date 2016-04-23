﻿using UnityEngine;
using System.Collections;

public class SwitchCars : MonoBehaviour {
	public GameObject player;
	public Transform civicWaypoint;
	private ChoiceController cc;
	// Use this for initialization
	void Start () {
		cc = (ChoiceController) FindObjectOfType(typeof(ChoiceController));
		if (!cc.choice1) {
			player.transform.position = civicWaypoint.position;
		}
	}
	// Update is called once per frame
	void Update () {
	}
}
