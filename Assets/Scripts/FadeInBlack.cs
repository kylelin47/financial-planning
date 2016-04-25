using UnityEngine;
using System.Collections;

public class FadeInBlack : MonoBehaviour {
	public float timeToFade;
	private bool beginFade;
	private CanvasRenderer[] renderers;
	// Use this for initialization
	void Start () {
		renderers = GetComponentsInChildren<CanvasRenderer> ();
		Invoke ("Disappear", timeToFade - 1);
	}
	private void Disappear() {
		beginFade = true;
	}
	// Update is called once per frame
	void Update () {
		if (beginFade) {
			foreach (CanvasRenderer cr in renderers) {
				cr.SetAlpha(cr.GetAlpha() - 0.1f);
			}
		}
	}
}
