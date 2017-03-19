using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title_Select : MonoBehaviour {
public Dropdown myPlayerSelect;			//Refer to myPlayerSelect.value + 2 for the number of players
	// Use this for initialization
void Start() {
	myPlayerSelect.onValueChanged.AddListener(delegate {
	myDropdownValueChangedHandler(myPlayerSelect);
     });
 }
void Destroy() {
		myPlayerSelect.onValueChanged.RemoveAllListeners();
 }
 
private void myDropdownValueChangedHandler(Dropdown target) {
     Debug.Log("selected: "+target.value);
 }
 
public void SetDropdownIndex(int index) {
		myPlayerSelect.value = index;
  }
}
