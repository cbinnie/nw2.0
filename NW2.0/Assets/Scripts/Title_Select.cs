using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title_Select : MonoBehaviour
{
	public GameObject player1;
	public GameObject player2;
	public GameObject player3;
	public GameObject player4;
	public GameObject player5;
	private ArrayList list_players = new ArrayList(5);

    public int playerCount;
    public GameManager gm;
    public Dropdown myPlayerSelect;         //Refer to myPlayerSelect.value + 2 for the number of players
                                            // Use this for initialization
    void Start()
    {
        myPlayerSelect.onValueChanged.AddListener(delegate
        {
            myDropdownValueChangedHandler(myPlayerSelect);
        });
    }
    void Destroy()
    {
        myPlayerSelect.onValueChanged.RemoveAllListeners();
    }

    private void myDropdownValueChangedHandler(Dropdown target)
    {
        Debug.Log("selected: " + target.value);
        this.playerCount = target.value + 2;
    }

    public void SetDropdownIndex(int index)
    {
        myPlayerSelect.value = index;
    }

    public void sendPlayerCount()
    {
        gm.setNumberPlayers(this.playerCount);
        list_players.Add(player1);
		list_players.Add(player2);
		list_players.Add(player3);
		list_players.Add(player4);
		list_players.Add(player5);

        for (int i = 0 ; i < this.playerCount; i++) {
			gm.playerList.Add(list_players[i]);
        }
    }
}
