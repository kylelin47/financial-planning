﻿using UnityEngine;
using UnityEditor.Animations;
using System.Collections;

public class TalkingIdleAnimator : MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setIsTalking(bool isTalking) {
		animator.SetBool("isTalking", isTalking);
	}
}
