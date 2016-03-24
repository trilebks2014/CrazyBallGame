using UnityEngine;
using System.Collections;

public class OnePlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			Application.LoadLevel ("CrazyBall");
		}

	}
	void OnMouseDown(){
		Application.LoadLevel ("CrazyBall");

	}

}
