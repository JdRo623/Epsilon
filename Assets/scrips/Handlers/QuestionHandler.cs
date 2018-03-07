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
                        Debug.Log("Pregunta nivel 1");
                        pregunta = PreguntaSingleton.GetInstance().GetPreguntaNivel1();
                        LevelManagerSingleton.GetInstance().AdvanceState();

                        SetUI();
                        return;
                    case 2:
                        Debug.Log("Pregunta nivel 1 f");
                        pregunta = PreguntaSingleton.GetInstance().GetPreguntaNivel1Final();
                        LevelManagerSingleton.GetInstance().AdvanceState();
                        LevelManagerSingleton.GetInstance().AdvanceLevel();
                        SetUI();
                        return;
                }
                return;
            case 2:
                switch (start)
                {
                    case 1:
                        Debug.Log("Pregunta nivel 2");
                        pregunta = PreguntaSingleton.GetInstance().GetPreguntaNivel2();
                        LevelManagerSingleton.GetInstance().AdvanceState();
                        SetUI();
                        return;
                    case 2:
                        Debug.Log("Pregunta nivel 2f");
                        pregunta = PreguntaSingleton.GetInstance().GetPreguntaNivel2Final();
                        LevelManagerSingleton.GetInstance().AdvanceState();
                        LevelManagerSingleton.GetInstance().AdvanceLevel();
                        SetUI();
                        return;
                }
                return;
            case 3:
                switch (start)
                {
                    case 1:
                        Debug.Log("Pregunta nivel 3");
                        LevelManagerSingleton.GetInstance().AdvanceState();
                        pregunta = PreguntaSingleton.GetInstance().GetPreguntaNivel3();
                        SetUI();
                        return;
                    case 2:
                        Debug.Log("Pregunta nivel 3f");
                        LevelManagerSingleton.GetInstance().AdvanceState();
                        pregunta = PreguntaSingleton.GetInstance().GetPreguntaNivel3Final();
                        LevelManagerSingleton.GetInstance().AdvanceLevel();
                        SetUI();
                        return;
                }
                return;
        }
        
        

    }

    public void SetUI() {
        preguntaTittle.text = pregunta.GetTitulo();
        respuesta1.text = pregunta.GetRespuestas()[0];
        respuesta2.text = pregunta.GetRespuestas()[1];
        respuesta3.text = pregunta.GetRespuestas()[2];
    }
    public void SetRespuesta(int preguntaPos) {
      
        PreguntaSingleton.GetInstance().SetPreguntaDefinitiva(new Pregunta(pregunta.GetTitulo(), pregunta.GetRespuestas()[preguntaPos]));
        sceneTransition.CheckLevel();
    }
}
