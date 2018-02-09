using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambio : MonoBehaviour {

    public void MetodoAl()
    {

        SceneManager.LoadScene("experimento 2018");

        int escena = SceneManager.GetActiveScene().buildIndex;


    }
}
