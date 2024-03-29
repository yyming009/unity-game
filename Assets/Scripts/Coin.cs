﻿using UnityEngine;

public class Coin : MonoBehaviour
{
	public float rotateSpeed = 50f;
	public int scorePoints = 10;


	void Update()
	{
		transform.Rotate (0, 0, 3);
	}

	void OnTriggerEnter(Collider col)
	{
		//increase score via some UIManager
		//destroy this gameobject
		Debug.Log("you hit a coin");
		FindObjectOfType<Score>().increaseScore (scorePoints);
		Destroy (this.gameObject);
	}
}


