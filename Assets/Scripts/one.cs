using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using System.Collections.Generic;

public class one : MonoBehaviour {
	public bool man1trig1940=false;
	public bool man1trig1950=false;
	public bool man1trig1960=false;
	public bool man1trig1970=false;
	public bool man1trig1980=false;
	void Start(){
		
	}
	void OnTriggerEnter(Collider other) 
		{
			if (other.gameObject.CompareTag("g21940"))
			{
				
				man1trig1940 = true;
			}
			if (other.gameObject.CompareTag("g21950"))
			{
				
				man1trig1940 = true;
			}
			if (other.gameObject.CompareTag("g21960"))
			{
				
				man1trig1940 = true;
			}
			if (other.gameObject.CompareTag("g21970"))
			{
				
				man1trig1940 = true;
			}
			if (other.gameObject.CompareTag("g21980"))
			{
				
				man1trig1940 = true;
			}
		}
			
	void Update(){
		
		
	}
}