using UnityEngine;
using System.Collections;

public class PlayerStartController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		bool isRich = true;
		string startPosName = isRich ? "StartingPositionRich" : "StartingPositionPoor";
		Transform startPos = GameObject.FindGameObjectsWithTag(startPosName)[0].transform;
		transform.position = startPos.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
