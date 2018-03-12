using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundARound : MonoBehaviour {
	public Transform center;
	public float degreePerSecond = -70.0f;
	private Vector3 v;

	// Use this for initialization
	void Start () {
		v = transform.position - center.position;
	}
	
	// Update is called once per frame
	void Update () {
		v = Quaternion.AngleAxis (degreePerSecond * Time.deltaTime, Vector3.down) * v;
		transform.position = center.position + v;
		Vector3 relativePos = center.position - transform.position;
		transform.rotation = Quaternion.LookRotation (relativePos, new Vector3 (0, 1));
	}
}
