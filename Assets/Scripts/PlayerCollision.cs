﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public playerMovement movement;
	public float restartDelay = 1f;
	private bool startRug = false;
	private void Restart() {
		movement.enabled = true;
		//movement.setForce (200f,0);
	}

	void OnCollisionEnter(Collision collision) {
		//Debug.Log (collision.collider.tag);
		if (collision.collider.tag == "Obstacle") {
			movement.enabled = false;
			// if has 0 life left, end game 

			FindObjectOfType<GameManager> ().EndGame ();
			// else
			//restart game
		} else if (collision.collider.tag == "Rug") {

			if (!startRug) {
				startRug = true;
				//Debug.Log ("enter rug zone");
				//movement.enabled = false;
				//Invoke("Decrease", Time.deltaTime);
				movement.setDecrease (true);
			}
		} else if (collision.collider.tag == "Ground") {
			if (startRug) {
				startRug = false;
				movement.setDecrease (false);
			}
		}
	}

}