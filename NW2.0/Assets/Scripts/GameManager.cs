using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public ArrayList playerList;
    private ArrayList tiles;
    private GameObject currentPlayer;
    private GameObject board;
    public GameObject rollUI;
    private int turnCounter = 0;
    private int currentRoll = 0;

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(gameObject);//keep the game manager around for next screen
        // for debug testing without a scene transition
        //if (SceneManager.GetActiveScene().buildIndex == 1)
        //{
        //    setNumberPlayers(2);
        //}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void getRoll()
    {
        currentRoll = Random.Range(1, 6);
        rollUI.SendMessage("setRoll", currentRoll);
        movePlayer(currentPlayer, currentRoll);
    }

    public void setNumberPlayers(int num)
    {
        playerList = new ArrayList(num);
        Debug.Log("Players: " + num.ToString());
        SceneManager.LoadScene(1);
        rollUI = GameObject.Find("RollText");
        setupScene1();
    }

    public void setupScene1()
    {
        switch (playerList.Capacity)
        {
            case 5: 
            case 4:
            case 3:
            case 2:
                break;
            default:
                Debug.Log("wrong number of players...");
                break;
        }
    }

    private void movePlayer(GameObject player, int roll)
    {
        PlayerScript ps = player.GetComponent<PlayerScript>();
        ps.moveForward(roll);
    }
}
