using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
	public int damage = 1;
	public int time = 5;
	// Use this for initialization
	void Start () {
		StartCoroutine(Destroybullet());
	}

	IEnumerator Destroybullet(){
		yield return new WaitForSeconds(time);
		Destroy(gameObject);
	}
}
