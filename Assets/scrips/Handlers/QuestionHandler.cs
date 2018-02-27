using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestionHandler : MonoBehaviour {
    int level;
    int start; 
    Pregunta pregunta;
    public Text preguntaTittle;
    public Text respuesta1;
    public Text respuesta2;
    ScenesTransitionHandler sceneTransition;
    public Text respuesta3;
    // Use this for initialization
    void Start () {
        sceneTransition = new ScenesTransitionHandler();
        level = LevelManagerSingleton.GetInstance().GetLevel();
        start = LevelManagerSingleton.GetInstance().GetCurrentLevelState();
        switch (level) {
            case 1:
                switch (start) {
                    case 1:
                        pregunta = PreguntaSingleton.GetInstance().GetPreguntaNivel1();
                        break;
                    case 2:
                        pregunta = PreguntaSingleton.GetInstance().GetPreguntaNivel1Final();
                        break;
                }
                break;
            case 2:
                switch (start)
                {
                    case 1:
                        pregunta = PreguntaSingleton.GetInstance().GetPreguntaNivel2();
                        break;
                    case 2:
                        pregunta = PreguntaSingleton.GetInstance().GetPreguntaNivel2Final();
                        break;
                }
                break;
            case 3:
                switch (start)
                {
                    case 1:
                        pregunta = PreguntaSingleton.GetInstance().GetPreguntaNivel3();
                        break;
                    case 2:
                        pregunta = PreguntaSingleton.GetInstance().GetPreguntaNivel3Final();
                        break;
                }
                break;
        }
        SetUI();
        

    }

    public void SetUI() {
        preguntaTittle.text = pregunta.GetTitulo();
        respuesta1.text = pregunta.GetRespuestas()[0];
        respuesta2.text = pregunta.GetRespuestas()[1];
        respuesta3.text = pregunta.GetRespuestas()[2];
    }
    public void SetRespuesta(int preguntaPos) {
        sceneTransition.GoToGame();
        PreguntaSingleton.GetInstance().SetPreguntaDefinitiva(new Pregunta(pregunta.GetTitulo(), pregunta.GetRespuestas()[preguntaPos]));
    }
}
