using UnityEngine;
using System.Collections;
public class FloatingText : MonoBehaviour {
	public Transform target;
	public float timeActive;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, timeActive);
	}
	// Update is called once per frame
	void Update () {
		transform.LookAt(target);
	}
}
