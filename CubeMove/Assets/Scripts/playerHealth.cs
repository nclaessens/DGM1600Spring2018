using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {
		public const int maxHealth = 100;
		public int currentHealth = maxHealth;
		public Text hp;
		public Text maxHp;
	
	// Update is called once per frame
	void Update () {
		hp.text = currentHealth.ToString();
		maxHp.text = maxHealth.ToString();

	}

	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth <= 0) {
			currentHealth = 0;
			print("You're dead. Game Over");
		}
	}
}		


