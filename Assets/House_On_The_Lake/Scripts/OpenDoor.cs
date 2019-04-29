﻿using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {

	public float smooth = 2.0f;
	public float DoorOpenAngle = 90.0f;

	public AudioClip OpenAudio;
	public AudioClip CloseAudio;
	private bool AudioS;

	private Vector3 defaultRot;
	private Vector3 openRot;
	private bool open;
	private bool enter;
    [SerializeField]
    public GameObject door;

    

    

	// Use this for initialization
	void Start () {
		
			defaultRot = transform.eulerAngles;
			openRot = new Vector3 (defaultRot.x, defaultRot.y + DoorOpenAngle, defaultRot.z);
            Transform foo = transform;
            
        
		}
	
	// Update is called once per frame
	void Update () {
		if (open) {
			if (AudioS == false) {
				gameObject.GetComponent<AudioSource> ().PlayOneShot (OpenAudio);
				AudioS = true;
			}
            door.transform.eulerAngles = Vector3.Slerp (door.transform.eulerAngles, openRot, Time.deltaTime * smooth);
		} else {
			if (AudioS == true) {
				gameObject.GetComponent<AudioSource> ().PlayOneShot (CloseAudio);
				AudioS = false;
			}
            door.transform.eulerAngles = Vector3.Slerp (door.transform.eulerAngles, defaultRot, Time.deltaTime * smooth);

		}
		if (Input.GetKeyDown (KeyCode.F) && enter) {
			open = !open;
		}
}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			enter = true;
			}
        else if(col.tag == "Vampire")
        {
            open = true;
        }
		}

    void OnTriggerExit(Collider col)
{
	if (col.tag == "Player") {
		enter = false;
        }
        else if (col.tag == "Vampire")
        {
            open = false;

         }
    }
}