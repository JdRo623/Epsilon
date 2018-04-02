using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pregunta {

    string titulo;
    string[] respuestasPosibles;
    string respuesta;

    public Pregunta(string titulo, string[] respuestas) {
        this.titulo = titulo;
        this.respuestasPosibles = respuestas;
            }
    public Pregunta(string titulo, string respuesta)
    {
        this.titulo = titulo;
        this.respuesta = respuesta;
    }
    public string GetTitulo() {
        return titulo;
    }
    public string[] GetRespuestas()
    {
        return respuestasPosibles;
    }
    public string GetRespuesta() {
        return respuesta;
    }
    public void SetRespuesta(string respuesta) {
        this.respuesta = respuesta;
    }


    public override string ToString() {
        return "["+titulo + ": " + respuesta + "]";
    }
}
