using UnityEngine;
using System.Collections;

public class GameManagement : MonoBehaviour {



	public GameObject ball;
	public GameObject score;
	public int[,] brickArray = new int[100,100];

	public static GameManagement instance = null;

	// Use this for initialization
	void Start () {
		if (instance == null) {
			instance = this;
		} else if (instance != this)
			Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
