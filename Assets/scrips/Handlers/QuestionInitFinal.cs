using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionInitFinal : MonoBehaviour {
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
        PreguntaSingleton.GetInstance().SetPreguntaNivel1Final(pregunta1Nivel1);
        PreguntaSingleton.GetInstance().SetPreguntaNivel1Final(pregunta2Nivel1);
        PreguntaSingleton.GetInstance().SetPreguntaNivel1Final(pregunta3Nivel1);
        PreguntaSingleton.GetInstance().SetPreguntaNivel2Final(pregunta1Nivel2);
        PreguntaSingleton.GetInstance().SetPreguntaNivel2Final(pregunta2Nivel2);
        PreguntaSingleton.GetInstance().SetPreguntaNivel2Final(pregunta3Nivel2);
        PreguntaSingleton.GetInstance().SetPreguntaNivel3Final(pregunta1Nivel3);
        PreguntaSingleton.GetInstance().SetPreguntaNivel3Final(pregunta2Nivel3);
        PreguntaSingleton.GetInstance().SetPreguntaNivel3Final(pregunta3Nivel3);
        Debug.Log("adsfa "+PreguntaSingleton.GetInstance().GetPreguntaNivel1Final().getTitulo());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
