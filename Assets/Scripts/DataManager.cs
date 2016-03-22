using UnityEngine;
using System.Collections;

public class DataManager : MonoBehaviour {

	public int currentDecade;
	public string currentDataset;
	public string[] currentGroups;
	public int lastDecade;
	public string lastDataset;

	public string[] raceGroups = { "White", "Black", "Hispanic", "Middle Eastern", "Asian", "Multi-racial" };
	public string[] orientationGroups = {"Homosexual","Heterosexual","Bisexual" };

	// Use this for initialization
	void Start () {
		currentDecade = 1930;
		currentDataset = "Race";
		currentGroups = raceGroups;

		lastDecade = currentDecade;
		lastDataset = currentDataset;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
