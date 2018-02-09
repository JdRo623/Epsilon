using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour {

    public float Speed;

    void Start () {
        GetComponent<Rigidbody2D>().velocity = transform.right * Speed;
    }

	void Update () {
		
	}
}
