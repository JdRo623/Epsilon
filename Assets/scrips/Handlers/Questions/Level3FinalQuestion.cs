using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3FinalQuestion : MonoBehaviour {

    public string pregunta1;
    public string respuesta1Pregunta1;
    public string respuesta2Pregunta1;
    public string respuesta3Pregunta1;
    public string pregunta2;
    public string respuesta1Pregunta2;
    public string respuesta2Pregunta2;
    public string respuesta3Pregunta2;
    public string pregunta3;
    public string respuesta1Pregunta3;
    public string respuesta2Pregunta3;
    public string respuesta3Pregunta3;
    void Start () {
        string[] respuestas = { respuesta1Pregunta1, respuesta2Pregunta1, respuesta3Pregunta1 };
        PreguntaSingleton.GetInstance().SetPreguntaNivel3Final(pregunta1, respuestas);
        respuestas = new string[] { respuesta1Pregunta2, respuesta2Pregunta2, respuesta3Pregunta2 };
        PreguntaSingleton.GetInstance().SetPreguntaNivel3Final(pregunta2, respuestas);
        respuestas = new string[] { respuesta1Pregunta3, respuesta2Pregunta3, respuesta3Pregunta3 };
        PreguntaSingleton.GetInstance().SetPreguntaNivel3Final(pregunta3, respuestas);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
