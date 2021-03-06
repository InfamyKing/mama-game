﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {
    public Transform player;
    public float relativeSpeed = .05f;
    private Vector3 start;
	// Use this for initialization
	void Start () {
        start = new Vector3(transform.position.x, transform.position.y, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.transform.position.x * relativeSpeed + start.x, transform.position.y, transform.position.z);
	}
}