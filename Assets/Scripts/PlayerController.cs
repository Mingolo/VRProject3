using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public GameObject head;
	public AudioSource teleportSound;
	public ParticleSystem teleportParticles;
	public int walkRange;

	private int groundMask;
	private Ray moveRay;
	private RaycastHit walkHit;

	// Use this for initialization
	void Start () 
	{
		groundMask = LayerMask.GetMask ("Ground");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("Fire1"))
		{
			Move();
		}
	}

	private void Move()
	{		
		moveRay.origin = head.transform.position;
		moveRay.direction = head.transform.forward;

		if (Physics.Raycast (moveRay, out walkHit, walkRange, groundMask)) 
		{
			teleportParticles.Play();
			teleportSound.Play();
			transform.position = walkHit.point;
		}
	}
}
