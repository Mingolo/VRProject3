using UnityEngine;
using System.Collections;

public class SwapTriggerController : MonoBehaviour 
{
	public Mesh targetMesh;
	public Material targetMaterial;

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
			other.gameObject.GetComponent<MeshFilter>().mesh = targetMesh;
			other.gameObject.GetComponent<MeshRenderer>().material = targetMaterial;
		}
	}
}
