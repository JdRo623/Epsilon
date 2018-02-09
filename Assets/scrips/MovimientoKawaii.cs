using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class MovimientoKawaii : MonoBehaviour {

	public int Speed;
	public float Speedup;
	//private Rigidbody2D rb;

	void Start ()
	{
	//	rb = GetComponent<Rigidbody2D> ();
	}

	void Update () 
	{
	
		float horizontal = Input.GetAxis ("Horizontal");
		float Vertical = Input.GetAxis ("Vertical");
		transform.Translate (Time.deltaTime * (Speed * horizontal),(Speedup * Vertical),0); 

	}
}
