using UnityEngine;
using System.Collections;

public class SwapTriggerController : MonoBehaviour 
{
	public GameObject targetObject;
	Animator anim;
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
			anim=newO.GetComponent<Animator>();
			anim.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load("walk2", typeof(RuntimeAnimatorController ));
			newO.transform.parent = other.gameObject.transform.parent;
			newO.transform.name = other.gameObject.transform.name;
			Destroy (other.gameObject, 0);
		}
	}
}

