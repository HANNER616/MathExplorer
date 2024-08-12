using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AreaPuerta : MonoBehaviour
{
    public Controller Controller;
    public GameLogic GameLogic;
    public Puerta Puerta;
    public CuadroDialogo CuadroDialogo;
    
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
                        CuadroDialogo.mostrarCuadroDialogo("La puerta se ha abierto!.");
                        Controller.hasAllKeys = false;
                        Destroy(gameObject);
                    }
                    else
                    {
                    }

                }
                

            }
        
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hasAllKeys();
        }
        
    }


    void hasAllKeys()
    {
        if (Controller.hasAllKeys)
        {

            Debug.Log("Has obtenido las llaves necesarias! Acercate a la puerta y presiona F para abrirla!");
            CuadroDialogo.mostrarCuadroDialogo("He obtenido las llaves necesarias!, Debo acercarme a la puerta y presionar la tecla F para abrirla!.");
            
        }
        else
        {
            Debug.Log("Te faltan recoger las llaves necesarias. Tienes: " + Controller.GetAuxKeys + "/" + GameLogic.GetNumKeys);
            CuadroDialogo.mostrarCuadroDialogo("Aun no puedo abrir la puerta, me faltan las llaves necesarias. Tengo " + Controller.GetAuxKeys + " llaves de " + GameLogic.GetNumKeys + " llaves totales");
            
        }
    }

    private IEnumerator espera()
    {
        yield return new WaitForSeconds(10);
    }

}
