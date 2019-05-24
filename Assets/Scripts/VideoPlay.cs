using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MovieTexture mov = (MovieTexture)GetComponent<MeshRenderer>().material.mainTexture;

		mov.Play();
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
