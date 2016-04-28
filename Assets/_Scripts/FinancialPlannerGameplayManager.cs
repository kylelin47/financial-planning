using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FinancialPlannerGameplayManager : MonoBehaviour {

	public Autowalk walkingScript;

	public Text bossSubtitles;
	public Text secretarySubtitles;

	public GameObject tv1LargeUI;
	public GameObject tv2LargeUI;
	public GameObject tv3LargeUI;
	public GameObject tv4LargeUI;

	public GameObject tvCharts;

	public VoiceActingAudioManager bossAudioManager;
	public VoiceActingAudioManager secretaryAudioManager;

	public AudioClip[] bossClips;
	public AudioClip[] secretaryClips;

	private int bossClipIndex = 0;

	public SubtitleManager subtitleManager;

	TriggerManager currentTriggerManager;
	public TriggerCapture bossSubtitleTriggerObject;
	public TriggerCapture secretarySubtitleTriggerObject;

	public FinancialPlannerAnimator mcgillAnimator;

	private delegate void TriggerManager();

	void Start () {
		subtitleManager.subtitleText = secretarySubtitles;
		currentTriggerManager = null;

		bossSubtitleTriggerObject.triggerFunction = openingBossSubtitle;
		secretarySubtitleTriggerObject.triggerFunction = startSecretarySubtitles;

		walkingScript.enabled = true;
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

	public void openingBossSubtitle() {
		subtitleManager.subtitleText = bossSubtitles;
		subtitleManager.playSubtitleForTime("Welcome, Come on in!", 3, startBossSubtitles);
		if (bossClipIndex < bossClips.Length) {
			bossAudioManager.PlayAudio(bossClips[bossClipIndex++]);
		}
		mcgillAnimator.setIsTalking(true);
	}

	public void startBossSubtitles() {
		subtitleManager.subtitleText = bossSubtitles;
		subtitleManager.playSubtitleForTime("I'm so excited for us to get started on this journey together.", 4, bossSubtitle2);
		if (bossClipIndex < bossClips.Length) {
			bossAudioManager.PlayAudio(bossClips[bossClipIndex++]);
		}
	}

	void bossSubtitle2() {
		subtitleManager.playSubtitleForTime("Today we will start you on your way to financial freedom, and success.", 4, bossSubtitle3);
		if (bossClipIndex < bossClips.Length) {
			bossAudioManager.PlayAudio(bossClips[bossClipIndex++]);
		}
		mcgillAnimator.pointForward();
	}

	void bossSubtitle3() {
		subtitleManager.playSubtitleForTime("I'm about to pull up variety of charts and graphs on the TVs behind me.", 4, bossSubtitle4);
		if (bossClipIndex < bossClips.Length) {
			bossAudioManager.PlayAudio(bossClips[bossClipIndex++]);
		}
		mcgillAnimator.pointBackward();
	}

	void bossSubtitle4() {
		subtitleManager.playSubtitleForTime("Take your time looking at everything.", 3, enableCharts);
		if (bossClipIndex < bossClips.Length) {
			bossAudioManager.PlayAudio(bossClips[bossClipIndex++]);
		}
	}

	void enableCharts() {
		mcgillAnimator.setIsTalking(false);
		tvCharts.SetActive(true);
	}
		
	public void startSecretarySubtitles() {
		subtitleManager.subtitleText = secretarySubtitles;
		subtitleManager.playSubtitleForTime("Welcome! Mr. McGill is ready for you.", 3, secretarySubtitle2);
		if (secretaryClips.Length > 0) {
			secretaryAudioManager.PlayAudio(secretaryClips[0]);
		}
	}

	void secretarySubtitle2() {
		subtitleManager.subtitleText = secretarySubtitles;
		subtitleManager.playSubtitleForTime("His office is just through those doors.", 3, null);
		if (secretaryClips.Length > 1) {
			secretaryAudioManager.PlayAudio(secretaryClips[1]);
		}
	}

	public void examineTV1UI() {
		disableAllLargeTVUI();
		tv1LargeUI.SetActive(true);
		currentTriggerManager = disableAllLargeTVUI;
		walkingScript.enabled = false;
	}

	public void examineTV2UI() {
		disableAllLargeTVUI();
		tv2LargeUI.SetActive(true);
		currentTriggerManager = disableAllLargeTVUI;
		walkingScript.enabled = false;
	}

	public void examineTV3UI() {
		disableAllLargeTVUI();
		tv3LargeUI.SetActive(true);
		currentTriggerManager = disableAllLargeTVUI;
		walkingScript.enabled = false;
	}

	public void examineTV4UI() {
		disableAllLargeTVUI();
		tv4LargeUI.SetActive(true);
		currentTriggerManager = disableAllLargeTVUI;
		walkingScript.enabled = false;
	}

	void disableAllLargeTVUI() {
		tv1LargeUI.SetActive(false);
		tv2LargeUI.SetActive(false);
		tv3LargeUI.SetActive(false);
		tv4LargeUI.SetActive(false);
		walkingScript.enabled = true;
	}

	public void advanceToNextLevel() {

	}
}
