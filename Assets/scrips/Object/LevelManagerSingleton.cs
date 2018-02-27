using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerSingleton {
    private int currentLevel;
    private int currentLevelState;
    private static LevelManagerSingleton instance;


    // Use this for initialization
    private LevelManagerSingleton() {
        currentLevel = 1;
        currentLevelState = 1;
    }

    public static LevelManagerSingleton GetInstance() {
        if (instance == null)
        {
            instance = new LevelManagerSingleton();
        }
        return instance;
    }

    public void AdvanceLevel() {
        currentLevel++;
    }
    public void Reset() {
        currentLevel = 1;
        currentLevelState = 1;
    }
    public int GetLevel() {
        return currentLevel;
    }
    public void AdvanceState() {
        switch (currentLevelState) {
            case 1:
                currentLevelState++;
                break;
            case 2:
                currentLevelState = 1;
                break;
        }
    }
    public int GetCurrentLevelState() {
        return currentLevelState;
    }
}
