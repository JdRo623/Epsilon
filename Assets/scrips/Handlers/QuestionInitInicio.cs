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


    // Use this for initialization
    void Start () {
        PreguntaSingleton.GetInstance().SetPreguntaNivel1(pregunta1Nivel1);
        PreguntaSingleton.GetInstance().SetPreguntaNivel1(pregunta2Nivel1);
        PreguntaSingleton.GetInstance().SetPreguntaNivel1(pregunta3Nivel1);
        PreguntaSingleton.GetInstance().SetPreguntaNivel2(pregunta1Nivel2);
        PreguntaSingleton.GetInstance().SetPreguntaNivel2(pregunta2Nivel2);
        PreguntaSingleton.GetInstance().SetPreguntaNivel2(pregunta3Nivel2);
        PreguntaSingleton.GetInstance().SetPreguntaNivel3(pregunta1Nivel3);
        PreguntaSingleton.GetInstance().SetPreguntaNivel3(pregunta2Nivel3);
        PreguntaSingleton.GetInstance().SetPreguntaNivel3(pregunta3Nivel3);
      

        Debug.Log("hOLI; "+PreguntaSingleton.GetInstance().GetPreguntaNivel1().getTitulo());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
