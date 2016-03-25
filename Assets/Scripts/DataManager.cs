using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using System.Collections.Generic;

public class DataManager : MonoBehaviour {

	public static int currentDecade;
	public static string currentDataset;
	public static double[] currentNumbers;
	public static int lastDecade;
	public static string lastDataset;
	public static bool madePredictions;
	public static string updated;
	static bool theatreSwitch;
	static string currentTheatre, destinationTheatre;

	private GameObject Player;
	private GameObject Ground;
	private GameObject Grauman;
	private GameObject Pantages;
	private GameObject Kodak;
	private PlayerController playerControl;

	Dictionary<string, Year> data;

	// Use this for initialization
	void Start () {
		//data input
		data = new Dictionary<string, Year>();
		data.Add ("1930", new Year(new double[]{100d, 0d, 0d}, new double[]{91.6d, 2.8d, 5.6d}));
		data.Add ("1940", new Year(new double[]{98.2d, 1.8d, 0d}, new double[]{92.7d, 0d, 7.3d}));
		data.Add ("1950", new Year(new double[]{92.1d, 0d, 5.9d}, new double[]{92.3d, 0d, 7.7d}));
		data.Add ("1960", new Year(new double[]{96.4d, 1.8d, 1.8d}, new double[]{85.8d, 7.1d, 7.1d}));
		data.Add ("1970", new Year(new double[]{100d, 0d, 0d}, new double[]{96.2d, 1.9d, 1.9d}));
		data.Add ("1980", new Year(new double[]{92d, 2d, 6d}, new double[]{91.8d, 4.1d, 4.1d}));
		data.Add ("1990", new Year(new double[]{92.5d, 5.6d, 1.9d}, new double[]{96.2d, 1.9d, 1.9d}));
		data.Add ("2000", new Year(new double[]{80.7d, 11.3d, 8d}, new double[]{96.6d, 0d, 3.4d}));
		data.Add ("2010", new Year());

		//to do: add "correct" data for 2010

		//variable set up
		currentDecade = 1930;
		currentDataset = "race";
		currentNumbers = data["1930"].getRaceData();
		currentTheatre = "grauman";
		destinationTheatre = "grauman";

		lastDecade = currentDecade;
		lastDataset = currentDataset;

		madePredictions = false;
		theatreSwitch = false;

		Player = GameObject.FindWithTag("Player");
		Ground = GameObject.FindWithTag("Ground");
		Grauman = GameObject.FindWithTag("Grauman");
		Pantages = GameObject.FindWithTag("Pantages");
		Kodak = GameObject.FindWithTag("Kodak");
		playerControl = Player.GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
		//sets theatre destination and determines when a theatre switch has occured.
		if (updated == "decade") {
			SetDestinationTheatre ();
		}

		//printUpdates ();
		UpdateData();
	
	}


	static bool isArrivedAtTheatre(){
		return destinationTheatre == currentTheatre;
	}
	public static bool makingPredictions(){
		return !madePredictions && currentDecade == 2010 && isArrivedAtTheatre();
	}

	void SetDestinationTheatre(){
		switch (lastDecade) {
			case 1930:
				if(currentDecade == 2010 && isArrivedAtTheatre()){
					Debug.Log ("kodak");
					theatreSwitch = true;
					destinationTheatre = "kodak";
				}
				break;
			case 1950:
				if (currentDecade == 1960 && isArrivedAtTheatre()) {
					Debug.Log ("pantages");
					destinationTheatre = "pantages";
					theatreSwitch = true;
				}
				break;
			case 1960:
				if (currentDecade == 1950 && isArrivedAtTheatre()) {
					Debug.Log ("grauman");
					destinationTheatre = "grauman";
					theatreSwitch = true;
				}
				break;
			case 1980:
				if (currentDecade == 1990 && isArrivedAtTheatre()) {
					Debug.Log ("kodak");
					destinationTheatre = "kodak";
					theatreSwitch = true;
				}
				break;
			case 1990:
				if (currentDecade == 1980 && isArrivedAtTheatre()) {
					Debug.Log ("pantages");
					destinationTheatre = "pantages";
					theatreSwitch = true;
				}
				break;
			case 2010:
				if (currentDecade == 1930 && isArrivedAtTheatre()) {
					Debug.Log ("grauman");
					destinationTheatre = "grauman";
					theatreSwitch = true;
				}
				break;
		}
	}
	//to do: add teleportation code, how it will work with changing location and how to move people between groups
	void UpdateData(){
		if(updated != ""){
			if(!theatreSwitch) {
				//proceed as normal if no change of location
				currentNumbers = GetCurrentNumbers();
			} 
			else {
				//teleport code here
				switch (destinationTheatre) {
				case "grauman":
					Vector3 temp = Grauman.transform.position;
					temp.y = Ground.transform.position.y;
					Player.transform.position = temp;
					break;
				case "pantages":
					Vector3 temp2 = Pantages.transform.position;
					temp2.y = Ground.transform.position.y;
					Player.transform.position = temp2;
					break;
				case "kodak":
					Vector3 temp3 = Kodak.transform.position;
					temp3.y = Ground.transform.position.y;
					Player.transform.position = temp3;
					break;
				}
				playerControl.TeleportEffects();
				currentTheatre = destinationTheatre;
				currentNumbers = GetCurrentNumbers();
				theatreSwitch = false;
			}
		}
		updated = "";	
	}

	public double[] GetCurrentNumbers(){
		if (currentDataset == "race") {
			return data [currentDecade.ToString ()].getRaceData ();
		} else {
			return data [currentDecade.ToString ()].getOrientationData ();
		}
		return null;
	}

	void printUpdates(){
		Debug.Log("current yr: " + currentDecade + " current data: " + currentDataset + " last yr: " + lastDecade+ " last data: " + lastDataset);
	}
}
