using UnityEngine;
using System.Collections;

public class PersonTestScript : MonoBehaviour 
{
	private float accTime;
	private int mult;

	// Use this for initialization
	void Start () 
	{
		accTime = 14;
		mult = 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		accTime -= Time.deltaTime;
		if (accTime <= 0) 
		{
			accTime = 14;
			mult = mult * -1;
		}
		transform.Translate(mult * transform.right * Time.deltaTime, Space.World);
	}
}
