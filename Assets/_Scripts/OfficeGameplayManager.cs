using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OfficeGameplayManager : MonoBehaviour {
	public Autowalk walkingScript;

	public Text deskText;
	public Text bossSubtitles;
	public Text secretarySubtitles;

	public GameObject largeCheck;
	public GameObject smallCheck;

	public VoiceActingAudioManager bossAudioManager;
	public VoiceActingAudioManager secretaryAudioManager;

	public AudioClip[] bossClips;
	public AudioClip[] secretaryClips;

	private int bossClipIndex = 0;

	public SubtitleManager subtitleManager;

	TriggerManager currentTriggerManager;
	public TriggerCapture bossSubtitleTriggerObject;
	public TriggerCapture secretarySubtitleTriggerObject;

	private delegate void TriggerManager();

	void Start () {
		subtitleManager.subtitleText = deskText;
		currentTriggerManager = tapToToggleWalkingStart;

		bossSubtitleTriggerObject.triggerFunction = startBossSubtitles;
		secretarySubtitleTriggerObject.triggerFunction = startSecretarySubtitles;

		walkingScript.enabled = false;
	}
	
	void Update () {
		if (Cardboard.SDK.Triggered) {
			if (currentTriggerManager != null) {
				Debug.Log("Cardboard Triggered");
				currentTriggerManager();
				// skipToFlying();
			}
		}
	}

	public void tapToToggleWalkingStart() {
		walkingScript.enabled = true;
		deskText.text = "Tap To Toggle Walking";
		currentTriggerManager = removeDeskText;
	}

	public void removeDeskText() {
		deskText.text = "";
	}

	public void startBossSubtitles() {
		subtitleManager.subtitleText = bossSubtitles;
		subtitleManager.playSubtitleForTime("Come In!, Come In!", 2, bossSubtitle2);
		if (bossClipIndex < bossClips.Length) {
			bossAudioManager.PlayAudio(bossClips[bossClipIndex++]);
		}
	}

	void bossSubtitle2() {
		subtitleManager.playSubtitleForTime("I have some great news for you today.", 2, bossSubtitle3);
		if (bossClipIndex < bossClips.Length) {
			bossAudioManager.PlayAudio(bossClips[bossClipIndex++]);
		}
	}

	void bossSubtitle3() {
		subtitleManager.playSubtitleForTime("You've been doing a great job at work, and I have a bonus check for you!", 4, bossSubtitle4);
		if (bossClipIndex < bossClips.Length) {
			bossAudioManager.PlayAudio(bossClips[bossClipIndex++]);
		}
	}

	void bossSubtitle4() {
		subtitleManager.playSubtitleForTime("It's right here on my desk, and you can take it whenever you are ready.", 3, offerCheckSubtitle);
		if (bossClipIndex < bossClips.Length) {
			bossAudioManager.PlayAudio(bossClips[bossClipIndex++]);
		}
	}

	void offerCheckSubtitle() {
		bossSubtitles.text = "Tap to Take Your Check";
		walkingScript.enabled = false;

		currentTriggerManager = tookCheck;
	}

	void tookCheck() {
		bossSubtitles.text = "";
		largeCheck.SetActive(true);
		smallCheck.SetActive(false);

		currentTriggerManager = closeCheck;
	}

	void closeCheck() {
		largeCheck.SetActive(false);

		subtitleManager.playSubtitleForTime("You can head home for the day now. Great work!", 3, null);
		if (bossClipIndex < bossClips.Length) {
			bossAudioManager.PlayAudio(bossClips[bossClipIndex++]);
		}

		walkingScript.enabled = true;
		currentTriggerManager = null;
	}

	public void startSecretarySubtitles() {
		subtitleManager.subtitleText = secretarySubtitles;
		subtitleManager.playSubtitleForTime("Hey there! Take a look at some of the new flyers on the bulletin board by the elevators.", 6, null);
		if (secretaryClips.Length > 0) {
			secretaryAudioManager.PlayAudio(secretaryClips[0]);
		}
	}
}
