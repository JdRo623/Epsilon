using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptQueVaEnLaBala : MonoBehaviour {

	public float Speed, lifetime;
	EstoEsLoQueHaceQueDispare Script;
    

    void Start () 
	{
		Script = GetComponent<EstoEsLoQueHaceQueDispare> ();
		GetComponent<Rigidbody2D> ().velocity = transform.right * Speed;
		Destroy (gameObject, lifetime);
       
    }

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.CompareTag ("Enemigo")) 
		{
			Debug.Log ("Enemigo ah Muerto");	
			Destroy (other.gameObject);

             

        }


    }
   

    }
   