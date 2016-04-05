	using UnityEngine;
using System.Collections;
using System;

public class ArrayBricks : MonoBehaviour {
	public GameObject brick;


	public int currentRow =-1;
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
		widthBrick = brick.GetComponent<BoxCollider2D>().size.x*100;
		heightBrick = brick.GetComponent<BoxCollider2D> ().size.y*100;
		numberOfBrickInOneLine = (int)(Screen.width / (widthBrick ));
		numberRowBrickInSceen = (int)(Screen.height / (heightBrick ));

		InvokeRepeating ("UpdateBrick", 0, timeAddingBrick);
		Debug.Log ("number" + numberOfBrickInOneLine);
	}
	void InitalBrick(){
		Debug.Log(numberOfBrickInOneLine);
		for (int j=0; j<numberOfBrickInOneLine; j++) {
			GameManagement.instance.brickArray[0,j]=1;
		}
	}
	void AddingOneLineBrick(){
		currentRow++;
		for (int j=0; j<numberOfBrickInOneLine; j++)
		{
			GameManagement.instance.brickArray[currentRow,j] = 1;
		}
	}

	public void positionToIndexAndReturnZero(float posX,float posY){
		int column = (int) Math.Floor((posStartBrickY - posY  ) / heightBrick);
		int row =(int)Math.Floor((posX - posStartBrickX) / widthBrick);

	}
	void DrawBrick(){

		for (int i=currentRow; i>=0; i--)
		{
			for (int j =0; j<numberOfBrickInOneLine; j++) 
			{

				if(GameManagement.instance.brickArray[i,j] != 0)
				{
						brick.name = String.Format("{0},{1}",i.ToString("D2"),j.ToString ("D2"));
						Instantiate (brick,new Vector2 (posStartBrickX + widthBrick * j, posStartBrickY - heightBrick *(currentRow- i)),Quaternion.identity);
				}
			}
		}
	}
	public void nameToIndexAndReturnBrickArray(string name){
		int row = Int32.Parse(name.Substring (0, 2));
		int column = Int32.Parse(name.Substring (3, 2));
		Debug.Log ("row" +row + " column" +column);
		GameManagement.instance.brickArray[row, column] = 0;
		Debug.Log ("brickArray[][]="+GameManagement.instance.brickArray [row, column]);

	}
	void showArray(){
		Debug.Log ("AAAA="+numberOfBrickInOneLine);
		for (int i=currentRow; i>=0; i--) 
		{
			Debug.Log ("AAAA11="+numberOfBrickInOneLine);
			for (int j =0; j<numberOfBrickInOneLine; j++) 
			{
				Debug.Log (i+ "  " + j + " = "+ GameManagement.instance.brickArray[i,j]);
				
			}
		}
	}
	void UpdateBrick()
	{
		//Debug.Log ("Truoc");
		//showArray ();
		AddingOneLineBrick ();
		DrawBrick ();
		Debug.Log ("Sau");

		showArray ();
	}
	void Update () {
	}
}
