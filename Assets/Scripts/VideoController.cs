using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoController : MonoBehaviour {

	private MovieTexture movie;

	void Start () {
		movie = GetComponent<Renderer>().material.mainTexture as MovieTexture;
		movie.Play();
	}

	void Update () {

	}
}
