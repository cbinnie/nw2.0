using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    public Tile nextTile;
    public string textEffect;
    public int scoreEffect;

	// Use this for initialization
	void Start () {
        

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Tile getNextTile()
    {
        return nextTile;
    }
    public string getTextEffect()
    {
        return textEffect;
    }
    public int getScoreEffect()
    {
        return scoreEffect;
    }

    public Vector3 getPosition()
    {
        return this.transform.position;
    }


}
