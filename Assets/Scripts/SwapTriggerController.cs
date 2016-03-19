using UnityEngine;
using System.Collections;

public class SwapTriggerController : MonoBehaviour 
{
	public GameObject targetObject;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("PersonMod"))
		{
			GameObject newO = (GameObject)Instantiate (targetObject, other.gameObject.transform.position, other.gameObject.transform.rotation);
			newO.transform.parent = other.gameObject.transform.parent;
			Destroy (other.gameObject, 0);
		}
	}
}
