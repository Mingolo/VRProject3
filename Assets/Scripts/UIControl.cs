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
	public GameObject predictionUI;
	public bool changeDisplay = true;
	bool horButtonPressed;
	bool verButtonPressed;

	public bool workingOnPredictions;

	// Use this for initialization
	void Awake () {
		decadeOptions = new string[]{"1930s", "1940s", "1950s", "1960s", "1970s", "1980s", "1990s", "2000s", "2010s"};
		dataOptions = new string[]{"race", "sexual orientation"};
		raceGroups = new string[]{ "white", "black", "other" };
		orientationGroups = new string[]{"homosexual","heterosexual","bisexual" };

		currentlyShowingArray = decadeOptions;
		currentlyShowingIndex = 0;
		lastIndexOppArray = 0;
		changeDisplay = true;
		horButtonPressed = verButtonPressed = false;

		workingOnPredictions = false;

	
	}
	
	// Update is called once per frame
	void Update () {


		if (!DataManager.makingPredictions ()) {
			if (changeDisplay) {
				mainText.text = currentlyShowingArray [currentlyShowingIndex];
				changeDisplay = false;

				for (int i = 0; i < dataText.Count; i++) {
					if (DataManager.currentDataset == "race") {
						dataText [i].text = raceGroups [i];
					} else {
						dataText [i].text = orientationGroups [i];
					}
				}

				for (int i = 0; i < dataNumbers.Count; i++) {
					dataNumbers [i].text = (DataManager.currentNumbers [i]).ToString () + " %";
				}
			}

			if (PredictionManager.workingOnPredictions == 0 | PredictionManager.workingOnPredictions > 5) {
				predictionUI.SetActive (false);
				if (Input.GetAxis ("Horizontal") > 0.5 | Input.GetAxis ("Horizontal") < -0.5) {
					//Debug.Log ("Hor press");
					if (Input.GetAxis ("Horizontal") > 0.5 && !horButtonPressed) {
						horButtonPressed = true;
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

					if (Input.GetAxis ("Horizontal") < -0.5 && !horButtonPressed) {
						horButtonPressed = true;
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
				} else {
					horButtonPressed = false;
				}


				if (Input.GetAxis ("Vertical") > 0.5 | Input.GetAxis ("Vertical") < -0.5) {
					if (Input.GetAxis ("Vertical") > 0.5 && !verButtonPressed) {
						verButtonPressed = true;
						SwapIndices ();
						if (currentlyShowingArray == decadeOptions) {
							currentlyShowingArray = dataOptions;
						} else {
							currentlyShowingArray = decadeOptions;
						}

						changeDisplay = true;
					}

					if (Input.GetAxis ("Vertical") < -0.5 && !verButtonPressed) {
						verButtonPressed = true;
						SwapIndices ();
						if (currentlyShowingArray == decadeOptions) {
							currentlyShowingArray = dataOptions;
						} else {
							currentlyShowingArray = decadeOptions;
						}

						changeDisplay = true;
					}
				} else {
					verButtonPressed = false;
				}
			}

		} else if(PredictionManager.workingOnPredictions == 0 ){
			PredictionManager.workingOnPredictions = 1;
			Debug.Log ("turning off regular ui");
			mainText.text = currentlyShowingArray [currentlyShowingIndex];
			for (int i = 0; i < dataText.Count; i++) {
				dataText [i].enabled = false;
			}
			for (int i = 0; i < dataNumbers.Count; i++) {
				dataNumbers [i].enabled = false;
			}

			predictionUI.SetActive (true);
			//move this to prediction manager
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

	public void reenableUI(){
		Debug.Log ("turing ui back on");
		for (int i = 0; i < this.dataText.Count; i++) {
			this.dataText [i].enabled = true;
		}
		for (int i = 0; i < this.dataNumbers.Count; i++) {
			this.dataNumbers [i].enabled = true;
		}
	}
}
