using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class UIControl : MonoBehaviour {
	public Text mainText;
	public List<Text> dataText, dataNumbers;
	public static string[] currentlyShowingArray;
	public int currentlyShowingIndex, lastIndexOppArray;
	public string[] decadeOptions;
	public string[] dataOptions;
	string lastItem;
	public string[] raceGroups;
	public string[] orientationGroups;

	public bool changeDisplay = true;

	// Use this for initialization
	void Awake () {
		decadeOptions = new string[]{"1930s", "1940s", "1950s", "1960s", "1970s", "1980s", "1990s", "2000s", "2010s"};
		dataOptions = new string[]{"race", "sexual orientation"};
		raceGroups = new string[]{ "White", "Black", "Other" };
		orientationGroups = new string[]{"Homosexual","Heterosexual","Bisexual" };

		currentlyShowingArray = decadeOptions;
		currentlyShowingIndex = 0;
		lastIndexOppArray = 0;
		changeDisplay = true;

	
	}
	
	// Update is called once per frame
	void Update () {
		if (changeDisplay) {
			mainText.text = currentlyShowingArray[currentlyShowingIndex];
			changeDisplay = false;

			for (int i = 0; i < dataText.Count; i++) {
				if (DataManager.currentDataset == "race") {
					dataText [i].text = raceGroups[i];
				} else {
					dataText [i].text = orientationGroups[i];
				}
			}

			for (int i = 0; i < dataNumbers.Count; i++) {
				dataNumbers [i].text = (DataManager.currentNumbers [i]).ToString();
			}
		}

		if (DataManager.makingPredictions()) {
			Debug.Log ("make predictions now!");
		}

		if (Input.GetButtonDown ("Horizontal") && Input.GetAxis("Horizontal") > 0) {
			if (currentlyShowingIndex + 1 != currentlyShowingArray.Length) {
				lastItem = currentlyShowingArray [currentlyShowingIndex];
				currentlyShowingIndex++;
			} else {
				lastItem = currentlyShowingArray [currentlyShowingIndex];
				currentlyShowingIndex = 0;
			}

			changeDisplay = true;
			UpdateDecadeAndData (lastItem);
		}

		if (Input.GetButtonDown ("Horizontal") && Input.GetAxis ("Horizontal") < 0) {
			if (currentlyShowingIndex - 1 != -1) {
				lastItem = currentlyShowingArray [currentlyShowingIndex];
				currentlyShowingIndex--;
			} else {
				lastItem = currentlyShowingArray [currentlyShowingIndex];
				currentlyShowingIndex = currentlyShowingArray.Length - 1;
			}

			changeDisplay = true;
			UpdateDecadeAndData (lastItem);
		}


		if (Input.GetButtonDown ("Vertical") && Input.GetAxis ("Vertical") > 0) {
			SwapIndices ();
			if (currentlyShowingArray == decadeOptions) {
				currentlyShowingArray = dataOptions;
			} else {
				currentlyShowingArray = decadeOptions;
			}

			changeDisplay = true;
		}

		if (Input.GetButtonDown ("Vertical") && Input.GetAxis ("Vertical") < 0) {
			SwapIndices ();
			if (currentlyShowingArray == decadeOptions) {
				currentlyShowingArray = dataOptions;
			} else {
				currentlyShowingArray = decadeOptions;
			}

			changeDisplay = true;
		}
	
	}

	void UpdateDecadeAndData(string lastItem){
		if (currentlyShowingArray == decadeOptions) {
			DataManager.lastDecade = int.Parse(lastItem.Split('s')[0]);
			DataManager.currentDecade = int.Parse(currentlyShowingArray [currentlyShowingIndex].Split('s')[0]);
			DataManager.updated = "decade";
		} else {
			DataManager.lastDataset = lastItem;
			DataManager.currentDataset = currentlyShowingArray [currentlyShowingIndex];
			DataManager.updated = "dataset";
		}
	}

	void SwapIndices(){
		int temp = lastIndexOppArray;
		lastIndexOppArray = currentlyShowingIndex;
		currentlyShowingIndex = temp;
	}
}
