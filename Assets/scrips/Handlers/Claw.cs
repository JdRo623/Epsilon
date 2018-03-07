using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Claw : MonoBehaviour {
    GameObject meteor;
    Rigidbody2D rigibody;
    bool flag;
    private void Start()
    {
        rigibody = GetComponent<Rigidbody2D>();
        flag = false;
       
    }
    public void DestroyMeteor()
    {
        Score.score++;
        Destroy(meteor);
    }
    public void InitClaw() {
        flag = true;
    }
    public void ResetClaw() {
        flag = false;
    }
    private void OnTriggerEnter2D (Collider2D other)
    {
       
        if (other.tag.Equals("Meteor")&& !flag) {
            flag = true;
            meteor = other.gameObject;
            meteor.transform.parent = this.transform;
            meteor.transform.position = transform.position;
            meteor.GetComponent<Rigidbody2D>().velocity = transform.right * 0;
        }
    }
}
