using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {
	//array delcaration
	public GameObject[] spawnPoints;

	public GameObject chicken;
	public int chickenCount;

	//int currentChickens;

	//public int maxChickens;


	// Use this for initialization
	void Start () {
		//find all spawn points with the tag respawn
		spawnPoints = GameObject.FindGameObjectsWithTag("Respawn");
		//chicken = GameObject.Find("Chicken");
		chicken = (GameObject)Resources.Load("chicken", typeof(GameObject));

		//curentChickens = MaxChickens;
		//Spawn Chicken
		Spawn();
		
	}
	
	// Update is called once per frame
	void Update () {
		// if(currentChicken < maxChickens){
		// Spawn();	
		//}
	}

	//Function that spawns chicken
	void Spawn(){
		for(int i =0; i < chickenCount; i++) {

		
		int spawn = Random.Range(0, spawnPoints.Length);

		GameObject.Instantiate(chicken, spawnPoints[spawn].transform.position, Quaternion.identity);
		}
	
	}

}
