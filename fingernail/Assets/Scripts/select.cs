using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class select : MonoBehaviour {

	public Dropdown myDropdown;
	public GameObject normal;
	public GameObject triangle;
	public GameObject square;
	public Material pink;
	public Material red;
	public Material black;
	//public Renderer rend;

	void Start() {		
		
		myDropdown.onValueChanged.AddListener (delegate {
			myDropdownValueChangedHandler(myDropdown);
		});
	}

	void Destroy() {
		myDropdown.onValueChanged.RemoveAllListeners();
	}

	private void myDropdownValueChangedHandler(Dropdown target) {
		
		if (target.value == 0) {
			Debug.Log ("selected color: pink");
			normal.GetComponent<Renderer>().material=pink;
			triangle.GetComponent<Renderer>().material=pink;
			square.GetComponent<Renderer>().material=pink;

		} else if (target.value == 1) {
			Debug.Log ("selected color: red");
			normal.GetComponent<Renderer>().material=red;
			triangle.GetComponent<Renderer>().material=red;
			square.GetComponent<Renderer>().material=red;


		} else if (target.value == 2) {
			Debug.Log ("selected color: black");
			normal.GetComponent<Renderer>().material=black;
			triangle.GetComponent<Renderer>().material=black;
			square.GetComponent<Renderer>().material=black;

		}
	}

	public void SetDropdownIndex(int index) {
		myDropdown.value = index;
	}
}

