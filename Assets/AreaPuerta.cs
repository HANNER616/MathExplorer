using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaPuerta : MonoBehaviour
{
    public Controller Controller;
    public GameLogic GameLogic;
    public Puerta Puerta;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        





    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                
                if (Controller.hasAllKeys)
                {
                    Puerta.AbrirPuerta();
                    Debug.Log("Puerta abierta!");
                }
                else
                {
                }

            }
            hasAllKeys();
            
        }
    } 
    

    void hasAllKeys()
    {
        if (Controller.hasAllKeys)
        {

            Debug.Log("Has obtenido las llaves necesarias! Acercate a la puerta y presiona F para abrirla!");
        }
        else
        {
            Debug.Log("Te faltan recoger las llaves necesarias. Tienes: " + Controller.GetAuxKeys + "/" + GameLogic.GetNumKeys);
        }
    }
    
}
