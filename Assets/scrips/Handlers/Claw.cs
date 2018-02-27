using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Claw : MonoBehaviour {
    GameObject meteor;
    Rigidbody2D rigibody;

    private void Start()
    {
        rigibody = GetComponent<Rigidbody2D>();
       
    }
    public void DestroyMeteor()
    {
        Score.score++;
        Destroy(meteor);
    }
    public void InitClaw() {
        
    }
    public void ResetClaw() {
        
    }
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag.Equals("Meteor")) {
            meteor = other.gameObject;
            meteor.transform.parent = this.transform;
            meteor.transform.position = transform.position;
            meteor.GetComponent<Rigidbody2D>().velocity = transform.right * 0;
        }
    }
}
