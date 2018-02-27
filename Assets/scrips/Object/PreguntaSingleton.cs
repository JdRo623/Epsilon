using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreguntaSingleton {
    private List<Pregunta> nivel1;
    private List<Pregunta> nivel2;
    private List<Pregunta> nivel3;
    private List<Pregunta> nivel1Final;
    private List<Pregunta> nivel2Final;
    private List<Pregunta> nivel3Final;
    private List<Pregunta> elegidas;
    private static PreguntaSingleton instance;

    private PreguntaSingleton()
    {
        nivel1 = new List<Pregunta>();
        nivel2 = new List<Pregunta>();
        nivel3 = new List<Pregunta>();

        nivel1Final = new List<Pregunta>();
        nivel2Final = new List<Pregunta>();
        nivel3Final = new List<Pregunta>();

        elegidas = new List<Pregunta>();
    }

    public static PreguntaSingleton GetInstance() {
        if (instance == null)
        {
            instance = new PreguntaSingleton();
        }
        return instance;
    }

    public Pregunta GetPreguntaNivel1() {
        return nivel1[(Random.Range(0, nivel1.Count))]; 
    }
    public Pregunta GetPreguntaNivel2()
    {
        return nivel2[(Random.Range(0, nivel2.Count))];
    }
    public Pregunta GetPreguntaNivel3()
    {
        return nivel3[(Random.Range(0, nivel3.Count))];
    }
    public void SetPreguntaNivel1(string titulo,string[] respuestas) {
        nivel1.Add(new Pregunta(titulo,respuestas));
    }
    public void SetPreguntaNivel2(string titulo, string[] respuestas)
    {
        nivel2.Add(new Pregunta(titulo, respuestas));
    }
    public void SetPreguntaNivel3(string titulo, string[] respuestas)
    {
        nivel3.Add(new Pregunta(titulo, respuestas));
    }
    public Pregunta GetPreguntaNivel1Final()
    {
        return nivel1Final[(Random.Range(0, nivel1Final.Count))];
    }
    public Pregunta GetPreguntaNivel2Final()
    {
        return nivel2Final[(Random.Range(0, nivel2Final.Count))];
    }
    public Pregunta GetPreguntaNivel3Final()
    {
        return nivel3Final[(Random.Range(0, nivel3Final.Count))];
    }

    public void SetPreguntaDefinitiva(Pregunta pregunta) {
        elegidas.Add(pregunta);
    }

    public void SetPreguntaNivel1Final(string titulo, string[] respuestas)
    {
        nivel1Final.Add(new Pregunta(titulo, respuestas));
    }
    public void SetPreguntaNivel2Final(string titulo, string[] respuestas) 
    {
        nivel2Final.Add(new Pregunta(titulo, respuestas));
    }
    public void SetPreguntaNivel3Final(string titulo, string[] respuestas)
    {
        nivel3Final.Add(new Pregunta(titulo, respuestas));
    }
}
