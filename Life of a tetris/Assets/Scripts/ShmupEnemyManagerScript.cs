﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShmupEnemyManagerScript : MonoBehaviour {

	//public PlayerHealth playerHealth;       // Reference to the player's heatlh.
	public GameObject enemy;                // The enemy prefab to be spawned.
	public float spawnTime = 3f;            // How long between each spawn.
	private int enemyIndex; 


	void Start ()
	{
		enemyIndex = 0;
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
		InvokeRepeating ("Spawn", spawnTime, spawnTime);

	}


	void Spawn ()
	{
		Vector3 spawnPosition = new Vector3(Random.Range(-2.2f, 2.2f), 1.3f);         // An array of the spawn points this enemy can spawn from.

		// If the player has no health left...
		/*if(playerHealth.currentHealth <= 0f)
		{
			// ... exit the function.
			return;
		}*/

		// Find a random index between zero and one less than the number of spawn points.


		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		Instantiate (enemy, spawnPosition, Quaternion.identity);
	}
}
