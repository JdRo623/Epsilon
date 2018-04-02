using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenesTransitionHandler : MonoBehaviour {


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player")) {
            GoToQuestion();
        }
    }

    public void GoToGame() {


        switch (LevelManagerSingleton.GetInstance().GetLevel()) {
            
            case 1:
 
                Application.LoadLevel("Level1");
               
                break;
            case 2:
                Application.LoadLevel("Level2");
                break;
            case 3:
                Application.LoadLevel("Level3");
                break;
            default:
                LevelManagerSingleton.GetInstance().Reset();
                System.IO.File.WriteAllText("C:\\Respuestas\\respuesta_" + System.DateTime.Now.Day+ "_" + System.DateTime.Now.Month + "_"+ System.DateTime.Now.Year +
                    "_" + System.DateTime.Now.Hour + System.DateTime.Now.Minute + 
                    ".txt", "El usuario respondió: \n"+PreguntaSingleton.GetInstance().GetRespuestas());
                Application.LoadLevel("menu");
                break;

        }
    }
    public void GoToQuestion() {
        Application.LoadLevel("Question");
    }
    public void CheckLevel() {
        int level = LevelManagerSingleton.GetInstance().GetLevel();
        int start = LevelManagerSingleton.GetInstance().GetCurrentLevelState();
        switch (level)
        {
            case 1:
                switch (start)
                {
                    case 1:
                        GoToQuestion();
                        return;
                    case 2:
                        Debug.Log("Pregunta nivel 1 f");
                        GoToGame();
                        return;
                }
                return;
            case 2:
                switch (start)
                {
                    case 1:
                        Debug.Log("Pregunta nivel 2");
                        GoToQuestion();
                        return;
                    case 2:
                        Debug.Log("Pregunta nivel 2f");
                        GoToGame();
                        return;
                }
                return;
            case 3:
                switch (start)
                {
                    case 1:
                        Debug.Log("Pregunta nivel 3");
                        GoToQuestion();
                        return;
                    case 2:
                        Debug.Log("Pregunta nivel 3f");
                        GoToGame();
                        return;
                    default:
                        Debug.Log("Go to menu");
                        GoToGame();
                        break;
                }
                return;
            default:
                Debug.Log("Go to menu");
                GoToGame();
                break;
        }
    }
}
