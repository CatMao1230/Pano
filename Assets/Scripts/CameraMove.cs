using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	public float turnSpeed = 50f;

	void Start () {

	}

	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))
			transform.Rotate(new Vector3(-turnSpeed * Time.deltaTime, 0f, 0f));
		if(Input.GetKey(KeyCode.DownArrow))
			transform.Rotate(new Vector3(turnSpeed * Time.deltaTime, 0f, 0f));
		if(Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(new Vector3(0f, -turnSpeed * Time.deltaTime, 0f));
		if(Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(new Vector3(0f, turnSpeed * Time.deltaTime, 0f));
	}
}
