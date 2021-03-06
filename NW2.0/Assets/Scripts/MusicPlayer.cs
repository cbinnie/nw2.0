﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {
	private static MusicPlayer instance = null;
	public AudioSource audio;
 	public static MusicPlayer Instance {
    	 get { return instance; }
 	}
void Awake() {
	if (instance != null && instance != this) {
         Destroy(this.gameObject);
         return;
     } else {
         instance = this;
     }
   	  DontDestroyOnLoad(this.gameObject);
 	}
 }
 // any other methods you need