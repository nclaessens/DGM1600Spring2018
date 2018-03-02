using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {
	public float moveSpeed;
	public Transform target;

	// public int damage;

	// public GameObject pcHealth;

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
	//void Follow() {
	//	print("Wolf is Following!");
	//	transform.LookAt(target);
	//	transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		
	//}
	
	void OnTriggerStay(Collider other)
	 {
		 if(other.gameObject.name == "Player"){
			// Follow();
			print("I wuv you player");
		 }
		
		else{
			Wandering();

		}
	}

	void OnCollisionEnter(Collision other)
	{
		//if(other.gameObject.name == "Player"){
		//		var hit = other.gameObject;
		//		var health = hit.GetComponent<playerHealth>();
		// 		print("Wolf is Attacking!);

		// 		if(pcHealth != null){
		// 		//pcHealth.TakeDamage(damage);
		//		  pcHealth.gameObject.GetCompnet<playerHealth>().TakeDamage(damge);
		// }	
	}
}
