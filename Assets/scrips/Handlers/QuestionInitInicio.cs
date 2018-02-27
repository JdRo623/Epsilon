using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionInitInicio: MonoBehaviour {

    public string pregunta1Nivel1;
    public string pregunta2Nivel1;
    public string pregunta3Nivel1;
    public string pregunta1Nivel2;
    public string pregunta2Nivel2;
    public string pregunta3Nivel2;
    public string pregunta1Nivel3;
    public string pregunta2Nivel3;
    public string pregunta3Nivel3;
    public string pregunta4Nivel1;
    public string pregunta4Nivel2;
    public string pregunta4Nivel3;

    // Use this for initialization
    void Start () {
      

        Debug.Log("hOLI; "+PreguntaSingleton.GetInstance().GetPreguntaNivel1().GetTitulo());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
