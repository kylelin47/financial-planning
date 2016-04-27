using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour {
	public float initialAlpha;
	public float timeToFade;
	public float fadeSpeed;
	private bool beginFade;
	private CanvasRenderer[] renderers;
	// Use this for initialization
	void Start () {
		renderers = GetComponentsInChildren<CanvasRenderer> ();
		foreach (CanvasRenderer cr in renderers) {
			cr.SetAlpha(initialAlpha);
		}
		Invoke ("StartFade", timeToFade);
	}
	private void StartFade() {
		beginFade = true;
	}
	// Update is called once per frame
	void Update () {
		if (beginFade) {
			foreach (CanvasRenderer cr in renderers) {
				cr.SetAlpha(cr.GetAlpha() + fadeSpeed);
			}
		}
	}
}
