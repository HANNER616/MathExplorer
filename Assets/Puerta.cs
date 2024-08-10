using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    Rigidbody2D rb;
    public bool deslizaEnEjeX;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AbrirPuerta()
    {
        if (deslizaEnEjeX)
        {
            rb.MovePosition(rb.position + new Vector2(0.30f, 0));
            
        }
        else
            rb.MovePosition(rb.position + new Vector2(0, 0.30f));


    }
}
