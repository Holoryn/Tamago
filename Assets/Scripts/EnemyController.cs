﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	public float speed;

	private GameObject player;
	private Rigidbody rb;

	void Start() {
		player = GameObject.Find("Player");
		rb = GetComponent<Rigidbody>();

        // Randomize enemy starting position to a random collectible
        var coordinates = new int[] { -9, 9 };
        transform.position = new Vector3(coordinates[Random.Range(0, coordinates.Length)], 0.5f, coordinates[Random.Range(0, coordinates.Length)]);
	}

	void Update() {
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 
			speed * Time.deltaTime);
	}
}
