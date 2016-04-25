using UnityEngine;
using System.Collections;
public class FloatingText : MonoBehaviour {
	public Transform target;
	public float timeDisabled;
	public float timeActive;
	private Renderer[] renderers;
	// Use this for initialization
	void Start () {
		renderers = GetComponentsInChildren<Renderer> ();
		foreach (Renderer r in renderers) {
			r.enabled = false;
		}
		Invoke ("ShowText", timeDisabled);
		Destroy (gameObject, timeDisabled + timeActive);
	}
	private void ShowText() {
		foreach (Renderer r in renderers) {
			r.enabled = true;
		}
	}
	// Update is called once per frame
	void Update () {
		transform.LookAt(target);
	}
}
