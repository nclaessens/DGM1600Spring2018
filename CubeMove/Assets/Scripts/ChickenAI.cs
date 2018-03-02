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
		chickenPen = GameObject.FindGameObjectWithTag("Drop").transform;
	}
	
	// Update is called once per frame
	void OnTriggerStay(Collider other) 
	{
		// Makes chicken move away
		if(other.gameObject.name == "Player"){
			Debug.Log("Play has entered chickens trigger");
			transform.LookAt(other.gameObject.transform);
			transform.Rotate(0,180,0);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}	
		else{
			Wandering();
		}
	}
	void Wandering(){
	//print("Wolf is wandering!");

	// makes the animal wander
	transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
	int randomNum = Random.Range(0,360);
	//Projects ray in front of animal
	Vector3 fwd = transform.TransformDirection(Vector3.forward);
	RaycastHit hit;

	Debug.DrawRay(transform.position,fwd*3,Color.red);

	if(Physics.Raycast(transform.position,fwd,out hit,3)){

		if(hit.collider.tag == "Wall"){
			transform.Rotate(0,randomNum,0);
		}
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
