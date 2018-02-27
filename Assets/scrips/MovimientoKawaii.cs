using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class MovimientoKawaii : MonoBehaviour {

	public int Speed;
	public float Speedup;
    float horizontalAxis;
    float verticalAxis;
    //private Rigidbody2D rb;

    void Start()
    {
        //	rb = GetComponent<Rigidbody2D> ();}
    }
    void Update()
    {
        if (transform.position.y <= -7 && Input.GetAxis("Vertical") <0)
        {
            verticalAxis = 0;
        } else if (transform.position.y >= 5 && Input.GetAxis("Vertical") > 0) {
            verticalAxis = 0;
        }
        else {
            verticalAxis = Input.GetAxis("Vertical");
        }
        if (transform.position.x <= -12 && Input.GetAxis("Horizontal") < 0)
        {
            horizontalAxis = 0;
        }
        else {
            horizontalAxis = Input.GetAxis("Horizontal");
        }
		

		transform.Translate(Time.deltaTime * (Speed * horizontalAxis),(Speedup * verticalAxis),0); 

	}
}
