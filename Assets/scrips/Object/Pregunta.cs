using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pregunta {

    string titulo;
    string respuesta;

    public Pregunta(string titulo, string respuesta) {
        this.titulo = titulo;
        this.respuesta = respuesta;
            }

    public string getTitulo() {
        return titulo;
    }
    public string getRespuesta() {
        return respuesta;
    }
    public void setRespuesta(string respuesta) {
        this.respuesta = respuesta;
    }
}
