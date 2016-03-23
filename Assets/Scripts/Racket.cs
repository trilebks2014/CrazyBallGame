using UnityEngine;
using System.Collections;
using System;
public class Racket : MonoBehaviour {

	public float speed=1050;
	// Use this for initialization
	void Start () {
	
	}
	void FixedUpdate () {
		// Get Horizontal Input
		float h = Input.GetAxisRaw("Horizontal");
		
		// Set Velocity (movement direction * speed)
		GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
	}
	// Update is called once per frame
	void Update () {
	}
}
