using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class selectsh : MonoBehaviour {

	public Dropdown Dropdown;
	public GameObject normal;
	public GameObject triangle;
	public GameObject square;

	void Awake (){
		//normal.TrackableEventHandler.isVisible == true;
		normal.SetActive(true);
		triangle.SetActive(false);
		square.SetActive(false);
	}

	void Start() {		
		Dropdown.onValueChanged.AddListener (delegate {
			myDropdownValueChangedHandler(Dropdown);
		});
	}

	void Destroy() {
		Dropdown.onValueChanged.RemoveAllListeners();
	}

	private void myDropdownValueChangedHandler(Dropdown target) {
		
		if (target.value == 0) {
			Debug.Log ("selected shape: normal");
			normal.SetActive(true);
			triangle.SetActive(false);
			square.SetActive(false);

		} else if (target.value == 1) {
			Debug.Log ("selected shape: triangle");
			normal.SetActive(false);
			triangle.SetActive(true);
			square.SetActive(false);

		} else if (target.value == 2) {
			Debug.Log ("selected shape: square");
			normal.SetActive(false);
			triangle.SetActive(false);
			square.SetActive(true);

		}
	}

	public void SetDropdownIndex(int index) {
		Dropdown.value = index;
	}
}

