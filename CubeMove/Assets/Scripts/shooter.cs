using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour {
	public Rigidbody projectile;
	public Transform target;
	public int shootSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			Rigidbody clone;
			clone = (Rigidbody)Instantiate(projectile, target.position, target.rotation);
			clone.velocity = target.TransformDirection (Vector3.forward*shootSpeed*Time.deltaTime);
		}
	}
}
