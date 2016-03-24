using UnityEngine;
using System.Collections;
using System;

public class ArrayBricks : MonoBehaviour {
	public GameObject brick;
	public int[,] brickArray = new int[100,100];
	public int currentRow =0;
	const float posStartBrickX= -70f;
	float spaceBrick = 10f;
	const float posStartBrickY= 115f;
	const float timeAddingBrick = 5f;
	int score = 0;
	float widthBrick;// = brick.GetComponent<BoxCollider2D>().size.x;
	float heightBrick;//=brick.GetComponent<BoxCollider2D> ().size.y;
	int numberOfBrickInOneLine;// = Screen.width / (widthBrick + spaceBrick);
	int numberRowBrickInSceen ;//= Screen.height / (heightBrick + spaceBrick);
	void Start () {
		widthBrick = 20;//brick.GetComponent<BoxCollider2D>().size.x;
		heightBrick = -20;//brick.GetComponent<BoxCollider2D> ().size.y;
		numberOfBrickInOneLine = (int)(Screen.width / (widthBrick + spaceBrick));
		numberRowBrickInSceen = (int)(Screen.height / (heightBrick + spaceBrick));
		InitalBrick ();
		InvokeRepeating ("UpdateBrick", timeAddingBrick, timeAddingBrick);
	}
	void InitalBrick(){
		Debug.Log(numberOfBrickInOneLine);
		for (int j=0; j<numberOfBrickInOneLine; j++) {
			brickArray[0,j]=1;
		}
	}
	void AddingOneLineBrick(){
		currentRow++;
		for (int j=0; j<numberOfBrickInOneLine; j++) {
			brickArray[currentRow,j] = 1;
		}
	}
	void DrawBrick(){

		for (int i=currentRow; i>=0; i--) {
			for (int j =0; j<numberOfBrickInOneLine; j++) {
				Debug.Log("aaaaaaaaaaaa"+	widthBrick);
				Vector2 positionBrick= new Vector2(posStartBrickX+widthBrick*j,posStartBrickY + heightBrick*i);
					if(brickArray[i,j] != 0){
						Instantiate (brick,positionBrick,Quaternion.identity);
						
					}
			}
		}

	}
	void UpdateBrick(){
		AddingOneLineBrick ();
		DrawBrick ();
		Debug.Log("5s");
	}
	void Update () {
	}
}
