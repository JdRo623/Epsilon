using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenesTransitionHandler : MonoBehaviour {
    // Use this for initialization
    /*void Start() {
        switch (levelId) {
            case 1:
                GoToGame();
                break;
            case 2:
                GoToQuestion();
                break;
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player")) {
            GoToQuestion();
        }
    }

    public void GoToGame() {

        Debug.Log("entra 1 "+ LevelManagerSingleton.GetInstance().GetLevel());
        switch (LevelManagerSingleton.GetInstance().GetLevel()) {
            
            case 1:
                LevelManagerSingleton.GetInstance().AdvanceLevel();
                Application.LoadLevel("Level1");
               
                break;
            case 2:
                LevelManagerSingleton.GetInstance().AdvanceLevel();
                Application.LoadLevel("Level2");
                break;
            case 3:
                LevelManagerSingleton.GetInstance().AdvanceLevel();
                Application.LoadLevel("Level3");
                break;
            default:
                LevelManagerSingleton.GetInstance().Reset();
                Application.LoadLevel("menu");
                break;

        }
    }
    public void GoToQuestion() {
        Application.LoadLevel("Question");
    }
}
