using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PredictionManager : MonoBehaviour {

	public Text sliderVal;
	public Slider slider;
	public Text currentGroup;
	public int[] predictedData;
	public int dataIndex;
	public string[] dataSets;
	public Text instructions;
	public Image bbutton;
	UIControl uiControl;

	public bool showActualRa, showPredictedOrient, showActualOrient;

	//0 - has not started process, 1 - in process, 2 - made predictions
	public static int workingOnPredictions;



	//button controls
	bool horButtonPressed;
	bool verButtonPressed;


	// Use this for initialization
	void Start () {
		predictedData = new int[6];
		dataSets = new string[]{ "white", "black", "other", "heterosexual", "homosexual", "bisexual"};
		dataIndex = 0;
		currentGroup.text = dataSets [dataIndex];
		sliderVal.text = slider.value.ToString();

		horButtonPressed = verButtonPressed = false;
		uiControl = GameObject.Find ("ControlUI").GetComponent<UIControl> ();
		bbutton.enabled = false;
		workingOnPredictions = 0;

		showActualRa = showPredictedOrient = showActualOrient = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetAxis ("Horizontal") > 0.5 | Input.GetAxis ("Horizontal") < -0.5) {
			if (Input.GetAxis ("Horizontal") > 0.5 && !horButtonPressed) {
				
				slider.value = slider.value + 1;
				sliderVal.text = slider.value.ToString ();
			}

			if (Input.GetAxis ("Horizontal") < -0.5 && !horButtonPressed) {
				
				slider.value = slider.value - 1;
				sliderVal.text = slider.value.ToString ();
			}
			horButtonPressed = true;
		}else {
			horButtonPressed = false;
		}

		if (Input.GetAxis ("Vertical") > 0.5 | Input.GetAxis ("Vertical") < -0.5) {

			if (Input.GetAxis ("Vertical") > 0.5 && !verButtonPressed && (dataIndex > 0)) {
				verButtonPressed = true;
				predictedData [dataIndex] = (int)slider.value;
				dataIndex--;
				slider.value = (float)predictedData [dataIndex];
				currentGroup.text = dataSets [dataIndex];
				sliderVal.text = slider.value.ToString ();
			
			}

			if (Input.GetAxis ("Vertical") < -0.5 && !verButtonPressed && (dataIndex < dataSets.Length - 1) ) {
				verButtonPressed = true;
				predictedData [dataIndex] = (int)slider.value;
				dataIndex++;
				slider.value = (float)predictedData [dataIndex];
				currentGroup.text = dataSets [dataIndex];
				sliderVal.text = slider.value.ToString ();
			}
		}else {
			verButtonPressed = false;
		}
	
		if (dataIndex == dataSets.Length - 1 && workingOnPredictions < 2) {
			instructions.text = "Submit";
			bbutton.enabled = true;

			if (Input.GetButton ("Fire2") && workingOnPredictions < 2) {
				predictedData [dataIndex] = (int)slider.value;
				workingOnPredictions = 2;
				//submitted values

				for (int i = 0; i < 3; i++) {
					uiControl.dataText [i].text = dataSets [i];
				}
				slider.gameObject.SetActive (false);
				bbutton.enabled = false;
				currentGroup.text = "";
				instructions.text = "Your prediction";
				sliderVal.text = "";
				uiControl.reenableUI ();

				DataManager.currentNumbers = sliceDataArray (true);
				DataManager.madePredictions = true;
				uiControl.changeDisplay = true;
			}
		}

		if (workingOnPredictions == 2 && !showActualRa) {
			Invoke ("showActualRaceData", 20);
		}

		if (workingOnPredictions == 3 && !showPredictedOrient) {
			Invoke ("showPredictedOrientation", 20);
		}

		if (workingOnPredictions == 4 && !showActualOrient) {
			Invoke ("showActualOrientation", 20);
		}

		if (workingOnPredictions == 5) {
			Invoke ("enableRegularDataViewing", 20);
		}
	}//end update

	void showActualRaceData(){
		instructions.text = "Statistically predicted values";
		DataManager.currentNumbers = DataManager.data ["2010"].getRaceData ();
		uiControl.changeDisplay = true;

		workingOnPredictions = 3;
		showActualRa = true;
	}

	void showPredictedOrientation(){
		DataManager.currentDataset = "orientation";
		instructions.text = "Your prediction";

		DataManager.currentNumbers = sliceDataArray (false);
		uiControl.changeDisplay = true;

		showPredictedOrient = true;	
		workingOnPredictions = 4;
	}

	void showActualOrientation(){
		instructions.text = "Statistically predicted values";
		DataManager.currentNumbers = DataManager.data ["2010"].getOrientationData ();
		uiControl.changeDisplay = true;

		workingOnPredictions = 5;
		showActualOrient = true;
	}


	void enableRegularDataViewing(){
		workingOnPredictions = 6;
	}

	double[] sliceDataArray(bool getFirstHalf){
		double[] temp = new double[3];
		if (getFirstHalf) {
			for (int i = 0; i < 3; i++) {
				temp[i] = (double) predictedData [i]*10;
			}
		} else {
			for (int i = 3; i < 6; i++) {
				temp[i-3] = (double) predictedData [i]*10;
			}
		}
		return temp;
	}


}
