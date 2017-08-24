using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionVideo : MonoBehaviour {

	public MovieTexture[] videos;
	private Renderer render;
	private MovieTexture curVideo;

	void Start () {
		render = GetComponent<Renderer> ();
		curVideo = videos[0];
		render.material.mainTexture = curVideo;
		videos[0].loop = true;
	}

	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			PlayVideo (videos [1]);
		} else {
			PlayVideo (videos [0]);
		}
	}

	void PlayVideo (MovieTexture video) {
		if (video.loop && !curVideo.isPlaying) {
			curVideo = video;
			render.material.mainTexture = curVideo;
			video.Play ();
		} else {
			if (!curVideo.isPlaying || !video.isPlaying) {
				if (!video.loop) {
					video.Stop ();
				}
				curVideo = video;
				render.material.mainTexture = curVideo;
				curVideo.Play ();
			}
		}
	}

}
