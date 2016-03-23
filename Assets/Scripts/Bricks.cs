using UnityEngine;
using System.Collections;
using System;
public class Bricks : MonoBehaviour {
	public GameObject[] prefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D collisionInfo) {
		// Destroy the whole Block
		System.Random random = new System.Random ();
		if (random.Next(1, 100) < 60) {
			
			int randomItem = random.Next (0,prefab.Length);
			Debug.Log ("Item "+randomItem);
			Instantiate(prefab[randomItem],new Vector2(transform.position.x,transform.position.y),Quaternion.identity);
		}
		Destroy(gameObject);
	}
}
