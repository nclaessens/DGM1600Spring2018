using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {
	public float moveSpeed;
	public Transform Chest;
	public int points = 10;

	// Use this for initialization
	void Start () {
		
	}
	

	
	void OnCollisionEnter(Collision other){
		//makes coins go into the chest
		if(other.gameObject.name == "Player"){
	// 		/* Destory(gameObject); */
	// 		//Add points to score.
	// 		scoreManager.AddPoints(points);
	// 		//Send coins to chest.
			transform.position = Chest.position;
			transform.rotation = Chest.rotation;
		}
	}
}
