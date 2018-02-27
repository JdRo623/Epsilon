using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {

    public static int score;
    public Text textScore;
	// Use this for initialization
	void Start () {
        Score.score = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
        textScore.text = "Puntaje: "+Score.score;

    }
}
