using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class muerte : MonoBehaviour {
	public GameObject player;
	public GameObject respawnPoint;
	public int timeOfDead;


	void OnTriggerEnter (Collider player) {

		if (player.gameObject.CompareTag("player")) 
		{
			Invoke ("MetodoMuerte",timeOfDead);
		}
	}

	void  MetodoMuerte ()
	{
			player.transform.position = respawnPoint.transform.position;
			print("te moristesss");

	}
}
