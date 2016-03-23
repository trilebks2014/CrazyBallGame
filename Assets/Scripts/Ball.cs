﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public float speed =100.0f;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity =new  Vector2(0,1).normalized * speed;
	}
	
	// Update is called once per frame
	void Update () {

	}
	float hitFactor(Vector2 ballPos,Vector2 racketPos, float racketWidth){
		return(ballPos.x-racketPos.x)/racketWidth;
	}
	void OnCollisionEnter2D(Collision2D col) {
		// Hit the Racket?
		if (col.gameObject.name == "racket") {
			// Calculate hit Factor
			float x=hitFactor(transform.position,
			                  col.transform.position,
			                  col.collider.bounds.size.x);
			
			// Calculate direction, set length to 1
			Vector2 dir = new Vector2(x, 1).normalized;
			
			// Set Velocity with dir * speed
			GetComponent<Rigidbody2D>().velocity = dir * speed;
		}
	}
}
