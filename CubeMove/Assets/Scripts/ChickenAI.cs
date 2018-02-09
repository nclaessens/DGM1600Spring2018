using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {
	public float moveSpeed;
	public Transform target;
	public Transform chickenPen;
	public int points = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerStay(Collider other) 
	{
		// Makes chicken move away
		if(other.gameObject.name == "Player"){
			Debug.Log("Play has entered chickens trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
		}	
	}
	void OnCollisionEnter(Collision other){
		//makes chicken go into pen
		if(other.gameObject.name == "Player"){
	// 		/* Destory(gameObject); */
	// 		//Add points to score.
	// 		scoreManager.AddPoints(points);
	// 		//Send Chicken to chicken pen.
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;

		}
		if(other.gameObject.name == "Bullet(Clone)"){
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
			Destroy(other.gameObject);
		}
	}
}
