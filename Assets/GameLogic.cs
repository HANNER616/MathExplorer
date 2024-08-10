using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    private int numKeys=0;
    void Start()
    {
        string Nivel = SceneManager.GetActiveScene().name;

        if (Nivel == "Level1")
        {
            numKeys = 1;
        }
        else if (Nivel == "Level2")
        {
            numKeys = 1;
        }
        else if (Nivel == "Level3")
        {
            numKeys = 2;
        }
        else if (Nivel == "Level4")
        {
            numKeys = 3;
        }
        else if (Nivel == "Level5")
        {
            numKeys = 4;
        }

        Debug.Log("Numero de llaves:  " + numKeys + " " + Nivel);



    }


    

    public int GetNumKeys
    {
        get { return numKeys; }
        
    }



    
}
