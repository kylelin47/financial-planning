using UnityEngine;
using System.Collections;

public class CarTreadmill : MonoBehaviour {
	public float speed;
	private Vector3 initialPosition;
	// Use this for initialization
	void Start () {
		initialPosition = transform.position;
	}
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * Time.deltaTime * speed);
	}
	void OnTriggerEnter(Collider other) {
		transform.position = initialPosition;
		speed += Random.Range (-2, 2);
	}
}
