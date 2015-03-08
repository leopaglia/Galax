﻿using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newPosition = transform.position;
        newPosition.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.position = newPosition;
	}
}
