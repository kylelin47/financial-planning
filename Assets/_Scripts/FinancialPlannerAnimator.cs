using UnityEngine;
using System.Collections;

public class FinancialPlannerAnimator : MonoBehaviour {

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

	public void pointForward() {
		animator.SetTrigger("point");
	}

	public void pointBackward() {
		animator.SetTrigger("pointBackward");
	}
}
