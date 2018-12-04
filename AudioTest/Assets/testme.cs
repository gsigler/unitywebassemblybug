using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class testme : MonoBehaviour
{

    [SerializeField] private GameObject _tmpObject;
    [SerializeField] private AudioSource _audioSource;
    private DateTime _start;

	// Use this for initialization
	void Start ()
	{
	    _start = DateTime.Now;
        _audioSource.Play();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (!_audioSource.isPlaying)
	    {
	        return;
	    }

        var temp = _tmpObject.GetComponent<TextMeshProUGUI>();
        if (temp != null)
		    temp.SetText(string.Format("Playing {0} seconds.  Audio Length {1}", (DateTime.Now - _start).TotalSeconds, _audioSource.clip.length));

        
	}
}
