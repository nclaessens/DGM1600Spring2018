using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NavChickenAI : MonoBehaviour {

	// Public 
	public Transform player;
	public float speed;
	// Wander 
	public float wanderRadius;
    public float wanderTimer;
	//Detection 
	public float alertDist;

	// Private 
	private Animator state;
	private Vector3 direction;
	private Transform target;
	private UnityEngine.AI.NavMeshAgent agent;
	private float timer;
	private float distance;

	void OnEnable () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
        timer = wanderTimer;
    }
	// Use this for initialization
	void Start () {
		state = GetComponent<Animator>();
		distance = Vector3.Distance(player.position, transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance(player.position, transform.position);
		
		// Alert
		if(distance < alertDist){
			print("Chickens sees player");
			state.SetBool("IsRunning",true);
			state.SetBool("IsWandering",false);
			speed = speed + 2;
			transform.LookAt(player);
			transform.Translate(Vector3.back*speed*Time.deltaTime);
		}
	

		
		//Wandering
		else if(distance > alertDist){
			 timer += Time.deltaTime;

			 	state.SetBool("IsRunning",false);
				state.SetBool("IsWandering",true);

			if (timer >= wanderTimer) {
			Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
			agent.SetDestination(newPos);
			timer = 0;
			}


		}

		
	}

	public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask) {
        Vector3 randDirection = Random.insideUnitSphere * dist;
 
        randDirection += origin;
 
        UnityEngine.AI.NavMeshHit navHit;
 
        UnityEngine.AI.NavMesh.SamplePosition (randDirection, out navHit, dist, layermask);
 
        return navHit.position;
    }
}