using UnityEngine;
using System.Collections;

public class InitiaBricks : MonoBehaviour {
	public GameObject[] bricks;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreateBricks", 5f, 9f);
	}
	void CreateBricks(){
		foreach(GameObject brick in bricks){
			Instantiate (brick);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
