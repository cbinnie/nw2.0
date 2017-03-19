using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
	public int score;//would like this to be an object that can be displayed at all times
	public Tile currTile;
	public float numSteps;
	public float delaySpeed;

	// Use this for initialization
	void Start ()
	{
		Vector3 target = currTile.getPosition ();
		while (transform.position != target)
		transform.position = Vector3.MoveTowards(transform.position, target, 100);
		moveForward (1);
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	public IEnumerator delayedMove(Vector3 target)
	{
		float step = numSteps * Time.deltaTime;
		while (transform.position != target)
		{
			transform.position = Vector3.MoveTowards (transform.position, target, step);
			yield return new WaitForSeconds(delaySpeed);
		}
	}

	public void moveForward(int numSpaces)
	{
		//move to the appropriate tile
		while (numSpaces > 0 && currTile.getNextTile())
		{
			currTile = currTile.getNextTile ();
			numSpaces--;
		}

		//move to the new tile
		StartCoroutine(delayedMove(currTile.getPosition ()));

		//show the text for the tile
		currTile.getTextEffect();//need to be able to display this

		//update the user's score
		score += currTile.getScoreEffect();
	}
}
