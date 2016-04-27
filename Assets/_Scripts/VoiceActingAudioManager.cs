using UnityEngine;
using System.Collections;

public class VoiceActingAudioManager : MonoBehaviour {

	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PlayAudio(AudioClip clip) {
		audioSource.Stop();
		if (clip != null) {
			audioSource.clip = clip;
			audioSource.Play();
		}
	}
}
