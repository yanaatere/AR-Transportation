using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Button))]
public class PlaySound : MonoBehaviour 
{

	public AudioClip sound;

	private Button button{get{return GetComponent<Button> (); }}
	private AudioSource	AudioSource {get{return GetComponent<AudioSource> ();}}

	// Use this for initialization
	void Start () {
		gameObject.AddComponent<AudioSource> ();
		AudioSource.clip = sound;
		AudioSource.playOnAwake = false;
		button.onClick.AddListener (() => ClickSound ());
	}
	
	// Update is called once per frame
	void ClickSound () {
		AudioSource.PlayOneShot(sound);
	}
}
