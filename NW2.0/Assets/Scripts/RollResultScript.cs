using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RollResultScript : MonoBehaviour {

    public GameObject gmObj;
    private GameManager manager;
    public Text rollText;
	// Use this for initialization
	void Start () {
        manager = gmObj.GetComponent<GameManager>();
        rollText.text = "-";
	}
	
    public void getRoll()
    {
        manager.getRoll();
    }

    void setRoll(int roll)
    {
        rollText.text = roll.ToString();
    }

	// Update is called once per frame
	void Update () {
		
	}
}
