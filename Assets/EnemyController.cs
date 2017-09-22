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
        var collectibles = GameObject.FindGameObjectsWithTag("Pick Up");
        transform.position = collectibles[Random.Range(0, collectibles.Length)].transform.position;
	}

	void Update() {
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 
			speed * Time.deltaTime);
	}
}
