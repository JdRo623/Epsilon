using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1FinalQuestion : MonoBehaviour {

    public string pregunta1Final;
    public string respuesta1Pregunta1Final;
    public string respuesta2Pregunta1Final;
    public string respuesta3Pregunta1Final;
    public string pregunta2Final;
    public string respuesta1Pregunta2Final;
    public string respuesta2Pregunta2Final;
    public string respuesta3Pregunta2Final;
    public string pregunta3Final;
    public string respuesta1Pregunta3Final;
    public string respuesta2Pregunta3Final;
    public string respuesta3Pregunta3Final;
    void Start () {
        string[] respuestas = { respuesta1Pregunta1Final, respuesta2Pregunta1Final, respuesta3Pregunta1Final };
        PreguntaSingleton.GetInstance().SetPreguntaNivel1Final(pregunta1Final, respuestas);
        respuestas = new string[] { respuesta1Pregunta2Final, respuesta2Pregunta2Final, respuesta3Pregunta2Final };
        PreguntaSingleton.GetInstance().SetPreguntaNivel1Final(pregunta2Final, respuestas);
        respuestas = new string[] { respuesta1Pregunta3Final, respuesta2Pregunta3Final, respuesta3Pregunta3Final };
        PreguntaSingleton.GetInstance().SetPreguntaNivel1Final(pregunta3Final, respuestas);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
