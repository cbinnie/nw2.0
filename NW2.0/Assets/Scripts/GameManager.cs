using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private ArrayList playerList;
    private ArrayList tiles;
    private GameObject currentPlayer;
    private GameObject board;
    public GameObject UI;
    private int turnCounter = 0;
    private int currentRoll = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void getRoll()
    {
        currentRoll = Random.Range(1, 6);
        UI.SendMessage("setRoll", currentRoll);
    }
}
